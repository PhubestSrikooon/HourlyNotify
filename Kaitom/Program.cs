using System;
using System.IO;
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
                if (File.Exists("update.bat")) { File.Delete("update.bat"); }
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
