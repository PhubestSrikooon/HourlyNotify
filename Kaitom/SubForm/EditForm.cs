using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaitom.SubForm
{
    public partial class EditForm : Form
    {
        public int rIndex;
        public string rName;
        public bool rActive;
        public string rFile;
        public List<string> rDate = new List<string>();
        public List<DateTime> rTime = new List<DateTime>();
        public int rVolume;
        public EditForm(int index, bool Active, string sName,string sFile,string sDate,string sTime,int sVolume)
        {
            InitializeComponent();
            panelWork(index,Active,sName,sFile,sDate,sTime,sVolume);

            VolumeTrackBar.ValueChanged += (s, e) =>
            {
                VolumeLabel.Text = $"ระดับเสียง : {VolumeTrackBar.Value}%";
            };

            FileSelect.Click += (s, e) =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MP3 Files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav|Ogg Files (*.ogg)|*.ogg";
                DialogResult dialogResult = ofd.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    FileNameTextBox.Text = ofd.FileName;
                }
            };
            AddTime.MouseDown += (s, e) => {
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
                collection.RemoveAt(TimeSelectPanel.Controls.Count - 1);
            };

            editedbtn.Click += (s, e) =>
            {
                if (TimeSelectPanel.Controls.Count < 1)
                {
                    MessageBox.Show("โปรดเพิ่มเวลาอย่างน้อย 1 เวลา","ข้อผิดพลาด",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (NameTextBox.Text.Length <= 0 || NameTextBox.Text == " ")
                {
                    MessageBox.Show("ชื่อไม่ควรว่างโปรดแก้ไขชื่อ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(FileNameTextBox.Text,"[A-Z]:"))
                {
                    MessageBox.Show("โปรดใส่ชื่อไฟล์ให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (!File.Exists(FileNameTextBox.Text))
                {
                    MessageBox.Show("ไม่พบไฟล์ที่คุณต้องการใช้", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rIndex = index;
                rActive = toggleswitch.Checked;
                rFile = FileNameTextBox.Text;
                rName = NameTextBox.Text;
                rVolume = VolumeTrackBar.Value;
                foreach (String listBox in DateSelectList.CheckedItems)
                {
                    rDate.Add(listBox);
                }
                Control.ControlCollection collection = TimeSelectPanel.Controls;
                foreach (DateTimePicker sin in collection)
                {
                    rTime.Add(sin.Value);
                }

                this.DialogResult = DialogResult.OK;
            };
        }

        void panelWork(int index, bool Active, string sName, string sFile, string sDate, string sTime, int sVolume)
        {
            NameTextBox.Text = sName;
            FileNameTextBox.Text = sFile;
            toggleswitch.Checked = Active;
            VolumeTrackBar.Value = sVolume;
            VolumeLabel.Text = $"ระดับเสียง : {VolumeTrackBar.Value}%";

            foreach (string str in sDate.Split(';'))
            {
                for (int i=0;i < DateSelectList.Items.Count; i++)
                {
                    if (DateSelectList.Items[i].ToString() == str)
                    {
                        DateSelectList.SetItemChecked(i, true);
                    }
                }
            }

            TimeSelectPanel.Controls.Clear();
            foreach (string t in sTime.Split(';'))
            {
                if (t == " " || t == null || t == "")
                {
                    continue;
                }
                DateTimePicker dateTime = new DateTimePicker();
                dateTime.Format = DateTimePickerFormat.Time;
                dateTime.Parent = TimeSelectPanel;
                dateTime.Value = DateTime.ParseExact(t,"hh:mm:ss tt",CultureInfo.CurrentCulture);
                dateTime.Dock = DockStyle.Top;
            }
            

            
        }
    }
}
