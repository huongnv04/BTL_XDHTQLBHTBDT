using BTL_GK.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_GK
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
           Application.Run(new Login());
            // Admin adminForm = new Admin(1); // Truyền vào role Admin (1)
            //Application.Run(adminForm); // Chạy Admin Form
          //Application.Run(new NhanVien());
        }
    }
}
