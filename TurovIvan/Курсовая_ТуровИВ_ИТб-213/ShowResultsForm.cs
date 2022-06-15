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
    public partial class ShowResultsForm : Form
    {
        public void ShowByArray(Sportsman[]array)
        {
            // создадим в dataGridView необходиые колонки
            groupResultsDG.Columns.Add("SportsmanName", "Спортсмен");
            groupResultsDG.Columns.Add("OBresult", "Всего баллов");
            for (int i = 0; i < Program.ecount; i++)
            {
                groupResultsDG.Columns.Add("E" + i, "Этап" + (i + 1));
            }
            // теперь заполним строки
            groupResultsDG.Rows.Add(array.Length);
            for (int i = 0; i < array.Length; i++)
            { 
                DataGridViewRow row = (DataGridViewRow)groupResultsDG.Rows[0].Clone();
                row.Cells[0].Value = array[i].Name;
                row.Cells[1].Value = array[i].obresult;
                for (int j = 0; j < Program.ecount; j++)
                {
                    row.Cells[2 + j].Value = array[i].results[j];
                }
                groupResultsDG.Rows.Add(row);
            }
            Show(); // показывает форму

        }
        public ShowResultsForm()
        {
            InitializeComponent();
        }
    }
}
