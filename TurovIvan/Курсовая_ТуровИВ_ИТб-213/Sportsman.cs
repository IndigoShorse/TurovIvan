using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_ТуровИВ_ИТб_213
{
    public class Sportsman
    {
        public string Name; // Имя участника

        public double obresult; // Поле хранящие общее кол-во баллов

        public int id; // Уникальный идентификатор спортсмена
        public int last_time; // Последнее набранное время (В конце хранит очки набранные в последнем абсолютном зачёте)
        public int[] time; // Поле целочисленных результатов и массив

        public double[] results; // Поле вещественных баллов, массив

        public void CalcSr() // Метод, который высчитывает сумму очков
        {
            obresult = 0;
            for(int i =0; i<results.Length;i++) //проходит по всем эллементам массива
                obresult+= results[i];
        }
        public static int comparuSM(Sportsman a, Sportsman b)
        {
            // если суммарный балл одинаков - по результатам последнего абсолютного зачёта
            if (a.obresult > b.obresult)
                return -1;
            else if (a.obresult < b.obresult)
                return 1;
            else if (a.last_time > b.last_time)
                return -1;
            else
                return 1;
        }
        // Высчитывает место, которое гонщик занял на этапе, на основании места сохраняет баллы
        public void GetEtapPlace(Sportsman[] etap, int index)
        {
            // Начальное значение места - последнее
            int place = etap.Length;
            for (int i = 0; i < etap.Length; i++)
                // Чтобы не произошло сравнения с самим собой
                if (etap[i].id != id)
                    // Если встретится одинаковое время, выше место будет у того, чей АйДи меньше(старше)
                    if (etap[i].time[index] > time[index] || (etap[i].time[index] == time[index] && etap[i].id > id))
                        place--;
            // Начальное значение - максимальный балл
            results[index] = 12;
            for (int i = 1; i < place && results[index] > 0; i++)
            {
                if (i < 3)
                    results[index]--;
                results[index]--;
            }
        }
        // Высчитывает место, которое гонщик занял на абсолютном зачёте, на основании места прибавляет баллы
        public void GetAbsPlace(Sportsman[] a, Sportsman[] b, Sportsman[] c, int index)
        {
            // Начальное значение места - последнее
            int place = a.Length + b.Length + c.Length;
            // То же, что и в групповом зачёте, но со всеми группами
            for (int i = 0; i < a.Length; i++)
                if (a[i].id != id)
                    if (a[i].time[index] > time[index] || (a[i].time[index] == time[index] && a[i].id > id))
                         place--;
            for (int i = 0; i < b.Length; i++)
                if (b[i].id != id)
                    if (b[i].time[index] > time[index] || (b[i].time[index] == time[index] && b[i].id > id))
                         place--;
            for (int i = 0; i < c.Length; i++)
                if (c[i].id != id)
                    if (c[i].time[index] > time[index] || (c[i].time[index] == time[index] && c[i].id > id))
                         place--;
            // Начальное значение - максимальный балл
            int result = 20;
            for (int i = 1; i < place && result > 0; i++)
            {
                if (i < 6)
                    result--;
                result--;
            }
            // В зачёт пойдёт половина от балла абсолютного зачёта
            results[index] += result / 2;
            last_time = result;
        }
    }
}
