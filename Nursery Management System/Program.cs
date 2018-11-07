using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Sign signForm = new Sign();
        public static signIn signInForm = new signIn();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*new Sign()*/ signForm);
<<<<<<< HEAD
            //Application.Run(new ParentForm());
=======
            Application.Run(new ChildForm());
>>>>>>> d432d16c1edd303b8c99d4af3178c065e9de8102
        }
    }
}
