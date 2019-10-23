using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IndentifiedFace
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain(new AppConfig("en")));

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmBegin(new AppConfig("en")));
            //Application.Run(new frmAddNewEmployee(new AppConfig("en")));
            Application.Run(new frmMain1(new AppConfig("en")));
            //Application.Run(new frmLogin(new AppConfig("en")));
            
            //Application.Run(new frmTimekeeping(new AppConfig("en")));
            //Application.Run(new frmMain(new AppConfig("en")));
            //Application.Run(new Form1());
        }
    }
}
