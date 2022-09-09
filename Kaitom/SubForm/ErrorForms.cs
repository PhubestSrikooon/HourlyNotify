using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Kaitom.SubForm
{
    public partial class ErrorForms : Form
    {
        public ErrorForms(string Title,string subTitle,Exception ex)
        {
            InitializeComponent();
            this.Text = Title;
            SystemSounds.Hand.Play();
            icons_box.Image = SystemIcons.Error.ToBitmap();
            if (ex.StackTrace == null)
            {
                richTextBox1.Text = "No stacktrace no need to report";
            }
            else
            {
                richTextBox1.Text = $"-- Please copy this stack trace to the clipboard and report at my github repo...  -- \nhttps://github.com/PhubestSrikooon/HourlyNotify/issues \n\n{ex.StackTrace}";
            }
            label1.Text = $"{subTitle} {ex.Message}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/PhubestSrikooon/HourlyNotify/issues");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
