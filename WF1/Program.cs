using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()//
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Lib_SMS.SMSSender sender = new Lib_SMS.SMSSender("vladmir.klepach@gmail.com", "1qaz@WSX", "Yana");
            var tmp = sender.Send("80631894543", "I love YOU!");
        }
    }
}
