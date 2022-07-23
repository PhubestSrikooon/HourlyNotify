using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaitom.SubForm
{
    public partial class AddForm : Form
    {
        public string sName;
        public string sFile;
        public int sVolume;
        public List<string> sDate = new List<string> { };
        public List<DateTime> sTime = new List<DateTime> { };
        public AddForm()
        {
            InitializeComponent();
            panelWork();

            // event listetener

            VolumeTrackBar.ValueChanged += (o, e) =>
            {
                VolumeLabel.Text = $"ระดับเสียง : {VolumeTrackBar.Value}%";
            };
        }

        private void panelWork()
        {
            AddTime.MouseDown += (s,e) => {
                DateTimePicker dateTime = new DateTimePicker();
                dateTime.Format = DateTimePickerFormat.Time;
                dateTime.Parent = TimeSelectPanel;
                dateTime.Value = DateTime.Now;
                dateTime.Dock = DockStyle.Top;
            };
            RemoveTme.MouseDown += (s, e) => {
                if (TimeSelectPanel.Controls.Count <= 0)
                {
                    return;
                }
                Control.ControlCollection collection = TimeSelectPanel.Controls;
                collection.RemoveAt(TimeSelectPanel.Controls.Count-1);
            };

            FileSelect.Click += (s, e) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav|Ogg Files (*.ogg)|*.ogg";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileNameTextBox.Text = openFileDialog.FileName;
                }
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TimeSelectPanel.Controls.Count < 1)
            {
                MessageBox.Show("โปรดเพิ่มเวลาอย่างน้อย 1 เวลา", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NameTextBox.Text.Length <= 0 || NameTextBox.Text == " ")
            {
                MessageBox.Show("ชื่อไม่ควรว่างโปรดแก้ไขชื่อ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(FileNameTextBox.Text, "[A-Z]:"))
            {
                MessageBox.Show("โปรดใส่ชื่อไฟล์ให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!File.Exists(FileNameTextBox.Text))
            {
                MessageBox.Show("ไม่พบไฟล์ที่คุณต้องการใช้", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sName = NameTextBox.Text;
            sFile = FileNameTextBox.Text;
            foreach (string item in DateSelectList.CheckedItems)
            {
                sDate.Add(item);
            }
            Control.ControlCollection collection = TimeSelectPanel.Controls;
            foreach (DateTimePicker s in collection)
            {
                sTime.Add(s.Value);
            }
            sVolume = VolumeTrackBar.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
