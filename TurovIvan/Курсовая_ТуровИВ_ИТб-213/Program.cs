using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_ТуровИВ_ИТб_213
{
    internal static class Program
    {
        public const int ecount = 6; //кол-во этапов, их всегда 6//

        public static int smcount; //кол-во участников//

        public static Sportsman[] groupA;
        public static Sportsman[] groupB;
        public static Sportsman[] groupC;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
