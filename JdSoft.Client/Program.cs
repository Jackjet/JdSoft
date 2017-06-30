using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JdSoft.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new Main0());
            }
            else
            {
                return;
            }
        }
    }
}
