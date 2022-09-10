using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaitom
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
            try
            {

                Application.Run(new MainForm());

            }
            catch (Exception ex)
            {
                SubForm.ErrorForms error1 = new SubForm.ErrorForms("Error", "มีข้อผิดพลาดเกิดขึ้น", ex);
                error1.ShowDialog();
            }
        }
    }
}
