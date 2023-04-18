using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /* ItemsShow I = new ItemsShow();
             I.Show();*/
            SignIn S = new SignIn();
            S.Show();
            /*SignUp1 S = new SignUp1();
            S.Show();*/
            /*Dashbord form = new Dashbord();
            form.Show();*/
            Application.Run();
            
        }
    }
}
