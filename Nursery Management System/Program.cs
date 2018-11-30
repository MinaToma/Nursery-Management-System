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
        public static sign signForm = new sign();
        public static signIn signInForm = new signIn();
        public static parentLoggedIn parentLoggedInForm = new parentLoggedIn();
        public static staffLoggedIn staffLoggedInForm = new staffLoggedIn(); 
        public static signUp signUpForm = new signUp();
        public static staffForm staffSignUpForm = new staffForm();
        public static parentForm parentSignUpForm = new parentForm("Parent");
        public static childForm childSignUpForm = new childForm();
        public static adminLoggedIn adminLoggedInForm = new adminLoggedIn();
        public static Parent globalParent = new Parent();
        public static editDatabase editDataBaseForm = new editDatabase();
        public static Child globalChild = new Child();
        public static Staff globalStaff = new Staff();
        public static Admin globalAdmin = new Admin();
        public static adminPendingRequests adminPendingRequestsForm = new adminPendingRequests();
        public static string globalType = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(signForm);
        }
    }
}
