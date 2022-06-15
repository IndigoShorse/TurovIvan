using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_ТуровИВ_ИТб_213
{
    public partial class MainForm : Form
    {
        // Переменные-счётчики
        int curGroupNum, curSMNum, curEtapNum;
        // Переменная, хранит суммарное количество всех гонщиков
        int totalLen;
        public MainForm()
        {
            InitializeComponent();
        }
        // Функция объединения всех групп и сортировки, используя поверхностное копирование
        private Sportsman[] ShallowCopyMerge()
        {
            Sportsman[] result = new Sportsman[totalLen];
            int j = 0;
            for (int i = 0; i < Program.groupA.Length; i++, j++)
                result[j] = Program.groupA[i];
            for (int i = 0; i < Program.groupB.Length; i++, j++)
                result[j] = Program.groupB[i];
            for (int i = 0; i < Program.groupC.Length; i++, j++)
                result[j] = Program.groupC[i];
            Array.Sort(result, new Comparison<Sportsman>(Sportsman.comparuSM));
            return result;
        }
        // Кнопка добавления имени в список
        private void AddButton_Click(object sender, EventArgs e)
        {
            string inName = nameBox.Text.Trim();
            if (inName == "")
                return;
            for (int i = 0; i < allNamesBox.Items.Count; i++)
                if (inName == allNamesBox.Items[i].ToString())
                {
                    errorLabel.Visible = true;
                    return;
                }
            errorLabel.Visible = false;
            allNamesBox.Items.Add(inName);
            nameBox.Clear();
            nameBox.Focus();

        }
        // Функция обрабатывает нажатие кнопки в поле ввода имени
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                AddButton_Click(sender, e);
        }
        // Высчитывает результаты, для записи в таблицу и отображения победителей
        private void calcResultsButton_Click(object sender, EventArgs e)
        {
            // Вычисление результатов гонщиков на каждом этапе
            for (int i = 0; i < Program.groupA.Length; i++)
                for (int j = 0; j < Program.ecount; j++)
                {
                    Program.groupA[i].last_time = (int)Program.groupA[i].time[j];
                    Program.groupA[i].GetEtapPlace(Program.groupA, j);
                    Program.groupA[i].GetAbsPlace(Program.groupA, Program.groupB, Program.groupC, j);
                }
            for (int i = 0; i < Program.groupB.Length; i++)
                for (int j = 0; j < Program.ecount; j++)
                {
                    Program.groupB[i].last_time = (int)Program.groupB[i].time[j];
                    Program.groupB[i].GetEtapPlace(Program.groupB, j);
                    Program.groupB[i].GetAbsPlace(Program.groupA, Program.groupB, Program.groupC, j);
                }
            for (int i = 0; i < Program.groupC.Length; i++)
                for (int j = 0; j < Program.ecount; j++)
                {
                    Program.groupC[i].last_time = (int)Program.groupC[i].time[j];
                    Program.groupC[i].GetEtapPlace(Program.groupC, j);
                    Program.groupC[i].GetAbsPlace(Program.groupA, Program.groupB, Program.groupC, j);
                }
            // Вычисляем суммарный счёт для каждого гонщика
            foreach (Sportsman sm in Program.groupA)
                sm.CalcSr();
            foreach (Sportsman sm in Program.groupB)
                sm.CalcSr();
            foreach (Sportsman sm in Program.groupC)
                sm.CalcSr();
            // Сортировка всех участников
            Array.Sort(Program.groupA, new Comparison<Sportsman>(Sportsman.comparuSM));
            Array.Sort(Program.groupB, new Comparison<Sportsman>(Sportsman.comparuSM));
            Array.Sort(Program.groupC, new Comparison<Sportsman>(Sportsman.comparuSM));
            // Вывод победителей на экран
            winnerABox.Text = Program.groupA[0].Name;
            winnerBBox.Text = Program.groupB[0].Name;
            winnerCBox.Text = Program.groupC[0].Name;
            // Теперь можно отобразить результаты
            showGroup1Button.Enabled = true;
            showGroup2Button.Enabled = true;
            showGroup3Button.Enabled = true;
        }
        // Отображает результаты группы
        private void resultButton_Click(object sender, EventArgs e)
        {
            ShowResultsForm frm2 = new ShowResultsForm();
            frm2.Show();
            if (sender == showGroup1Button)
                frm2.ShowByArray(Program.groupA); //результаты группы А
            else if (sender == showGroup2Button)
                frm2.ShowByArray(Program.groupB); //результаты группы В
            else if (sender == showGroup3Button)
                frm2.ShowByArray(Program.groupC); // результаты группы С
            else
                frm2.ShowByArray(ShallowCopyMerge()); // Результаты всех групп
        }
        // Отслеживает количество введённых секунд
        private void numericSecs_Changed(object sender, EventArgs e)
        {
            // Если секунд оказалось больше чем 60, то лучше всего перевести излишек в минуты
            if (numericSecs.Value >= 60)
            {
                numericMins.Value += numericSecs.Value / 60; // Прибавляем сколько минут получилось из излишка секунд
                numericSecs.Value %= 60; // Оставляем значение меньшее 60
            }
        }
        // Распределяет участников по 3-м группам
        private void splitGroups_Click(object sender, EventArgs e)
        {
            // Участников не может быть меньше 3
            if (allNamesBox.Items.Count < 3)
            {
                // Отобразит "сообщение" об ошибке
                errorLabel2.Visible = true;
                return;
            }
            errorLabel2.Visible = false;
            int count = 0;
            // Сохранение суммарного числа участников
            totalLen = allNamesBox.Items.Count;
            // Вычисление размеров групп
            int groupAcount = allNamesBox.Items.Count / 3;
            int groupBcount = (allNamesBox.Items.Count - groupAcount) / 2;
            int groupCcount = allNamesBox.Items.Count - groupAcount - groupBcount;
            Program.groupA = new Sportsman[groupAcount];
            Program.groupB = new Sportsman[groupBcount];
            Program.groupC = new Sportsman[groupCcount];
            // Инициализация групп с именами и создание полей-массивов
            for (int i = 0; i < Program.groupA.Length; i++)
            {
                Program.groupA[i] = new Sportsman();
                Program.groupA[i].results = new double[Program.ecount];
                Program.groupA[i].time = new int[Program.ecount];
                Program.groupA[i].Name = allNamesBox.Items[i].ToString();
                Program.groupA[i].id = count;
                count++;
            }
            for (int i = 0; i < Program.groupB.Length; i++)
            {
                Program.groupB[i] = new Sportsman();
                Program.groupB[i].results = new double[Program.ecount];
                Program.groupB[i].time = new int[Program.ecount];
                Program.groupB[i].Name = allNamesBox.Items[groupAcount + i].ToString();
                Program.groupB[i].id = count;
                count++;
            }
            for (int i = 0; i < Program.groupC.Length; i++)
            {
                Program.groupC[i] = new Sportsman();
                Program.groupC[i].results = new double[Program.ecount];
                Program.groupC[i].time = new int[Program.ecount];
                Program.groupC[i].Name = allNamesBox.Items[groupAcount + groupBcount + i].ToString();
                Program.groupC[i].id = count;
                count++;
            }
            // Переход на следующую вкладку, начальную можно закрыть
            mainTabs.TabPages.Remove(inputDataTab);
            curGroupNum = curSMNum = curEtapNum = 0;
            sportsmanNameLabel.Text = Program.groupA[curSMNum].Name;
            eNumberLabel.Text = "Этап" + (1 + curEtapNum).ToString();
        }
        // Записывает результат в поле участника
        private void nextSportsman_Click(object sender, EventArgs e)
        {
            // Если время равно 00:00, результат не будет записан, программа не переключится на следующего участника
            if (numericMins.Value == 0 && numericSecs.Value == 0)
                return;
            // Ввод времени, позже на основе этого будут высчитаны баллы
            if (curGroupNum == 0)
                Program.groupA[curSMNum].time[curEtapNum] = (int)(numericMins.Value * 60 + numericSecs.Value);
            else if (curGroupNum == 1)
                Program.groupB[curSMNum].time[curEtapNum] = (int)(numericMins.Value * 60 + numericSecs.Value);
            else
                Program.groupC[curSMNum].time[curEtapNum] = (int)(numericMins.Value * 60 + numericSecs.Value);
            // увеличивает номер этапа и выполняем расчеты в зависимости от
            // номера группы этапа, спортсмена и группы
            curEtapNum++;
            if (curEtapNum == Program.ecount)
            {
                curEtapNum = 0;
                curSMNum++;
                int cmpSMval;
                if (curGroupNum == 0)
                    cmpSMval = Program.groupA.Length;
                else if (curGroupNum == 1)
                    cmpSMval = Program.groupB.Length;
                else
                    cmpSMval = Program.groupC.Length;

                if (curSMNum == cmpSMval)
                {
                    curSMNum = 0;
                    curGroupNum++;
                }
            }
            // если все спортсмены получили все результаты(т.е.кол-во групп
            // превысило 3), то отключаем ввод данных
            if (curGroupNum <= 2)
            {
                if (curGroupNum == 0)
                {
                    groupNameLabel.Text = "Группа А";
                    sportsmanNameLabel.Text = Program.groupA[curSMNum].Name;
                    eNumberLabel.Text = "Этап" + (curEtapNum + 1).ToString();
                }
                else if (curGroupNum == 1)
                {
                    groupNameLabel.Text = "Группа Б";
                    sportsmanNameLabel.Text = Program.groupB[curSMNum].Name;
                    eNumberLabel.Text = "Этап" + (curEtapNum + 1).ToString();
                }
                else
                {
                    groupNameLabel.Text = "Группа В";
                    sportsmanNameLabel.Text = Program.groupC[curSMNum].Name;
                    eNumberLabel.Text = "Этап" + (curEtapNum + 1).ToString();
                }
            }
            else
            {
                // Замораживает все элементы для ввода времени, размораживает кнопку подсчёта результатов
                nextSportsman.Enabled = false;
                numericMins.Enabled = false;
                numericSecs.Enabled = false;
                groupNameLabel.Text = "Все результаты записаны!";
                sportsmanNameLabel.Text = null;
                eNumberLabel.Text = null;
                calcResultsButton.Enabled = true;
            }
            numericMins.Value = 0;
            numericSecs.Value = 0;
            numericMins.Focus();
        }
    }
}
