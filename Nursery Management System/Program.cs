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
        public static signUp signUpForm = new signUp();
        public static StaffForm staffSignUpForm = new StaffForm();
        public static signIn signInForm = new signIn();
        public static Parent globalParent = new Parent();
        public static Staff globalStaff = new Staff();
        public static Admin globalAdmin = new Admin();
        public static string globalType = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*new Sign()*/ signForm);
            //Application.Run(new ParentForm());
           // Application.Run(new ChildForm());
        }
    }
}
