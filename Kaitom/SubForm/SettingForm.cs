using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kaitom.SubForm
{
    public partial class SettingForm : Form
    {
        classes.appSetting appSetting = classes.appSetting.Instance;
        classes.XmlClass xml = new classes.XmlClass();
        classes.IniFile iniFile;

        public SettingForm()
        {
            InitializeComponent();
            StartUp1();
        }

        private void StartUp1()
        {
            iniFile = new classes.IniFile(appSetting.iniConfigfilePath);

            if (!System.IO.File.Exists(appSetting.iniConfigfilePath))
            {
                AutoRun.Checked = appSetting.defaultIniKey[0, 1];
                trackBar1.Value = appSetting.defaultIniKey[1, 1];
            }
            else
            {
                try
                {
                    AutoRun.Checked = Convert.ToBoolean(iniFile.Read(appSetting.defaultIniKey[0, 0]));
                    trackBar1.Value = Convert.ToInt32(iniFile.Read(appSetting.defaultIniKey[1, 0]));
                }
                catch (Exception ex)
                {
                    AutoRun.Checked = false;
                    trackBar1.Value = 0;
                }
            }
            List<classes.SoundInstanceClass> classesSIC = xml.ReadXML(appSetting.xmlConfigfilePath);
            try
            {
                foreach (classes.SoundInstanceClass cls in classesSIC)
                {
                    int n = SoundDataGridView.Rows.Add();
                    SoundDataGridView.Rows[n].Cells[0].Value = cls.Active;
                    SoundDataGridView.Rows[n].Cells[1].Value = cls.Name;
                    SoundDataGridView.Rows[n].Cells[2].Value = cls.File;
                    SoundDataGridView.Rows[n].Cells[3].Value = cls.Date;
                    SoundDataGridView.Rows[n].Cells[4].Value = cls.AlertTime;
                    SoundDataGridView.Rows[n].Cells[5].Value = cls.Volume;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            SubForm.AddForm addForm = new SubForm.AddForm();
            DialogResult addResult = addForm.ShowDialog();
            addForm.TopLevel = true;
            if (addResult == DialogResult.OK)
            {
                if (SoundDataGridView.RowCount > 0)
                {
                    
                    for (int i = 0; i <= SoundDataGridView.RowCount - 1; i++)
                    {

                        if (SoundDataGridView.Rows[i].Cells[1].Value.ToString() == addForm.sName)
                        {
                            MessageBox.Show("ชื่อนี้มีอยู่แล้วโปรดเปลี่ยนชื่อใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                int n = SoundDataGridView.Rows.Add();
                SoundDataGridView.Rows[n].Cells[1].Value = addForm.sName;
                SoundDataGridView.Rows[n].Cells[0].Value = true;
                SoundDataGridView.Rows[n].Cells[2].Value = addForm.sFile;
                SoundDataGridView.Rows[n].Cells[5].Value = addForm.sVolume;

                foreach (string day in addForm.sDate)
                {
                    SoundDataGridView.Rows[n].Cells[3].Value += $"{day};";
                }
                foreach (DateTime time in addForm.sTime)
                {
                    SoundDataGridView.Rows[n].Cells[4].Value += $"{time.ToString("hh:mm:ss tt")};";
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (SoundDataGridView.SelectedRows.Count > 0 && SoundDataGridView.SelectedCells.Count == 6)
            {
                var ins1 = SoundDataGridView.SelectedRows[0];
                SubForm.EditForm edit = new SubForm.EditForm(ins1.Index,
                    Convert.ToBoolean(ins1.Cells[0].Value),
                    ins1.Cells[1].Value.ToString(),
                    ins1.Cells[2].Value.ToString(),
                    ins1.Cells[3].Value.ToString(),
                    ins1.Cells[4].Value.ToString(),
                    Convert.ToInt32(ins1.Cells[5].Value)
                    );
                DialogResult result = edit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (SoundDataGridView.RowCount > 0)
                    {

                        for (int i = 0; i <= SoundDataGridView.RowCount - 1; i++)
                        {

                            if (SoundDataGridView.Rows[i].Cells[1].Value.ToString() == edit.rName && i != ins1.Index)
                            {
                                MessageBox.Show("ชื่อนี้มีอยู่แล้วโปรดเปลี่ยนชื่อใหม่", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    ins1.Cells[1].Value = edit.rName;
                    ins1.Cells[0].Value = edit.rActive;
                    ins1.Cells[2].Value = edit.rFile;
                    ins1.Cells[5].Value = edit.rVolume;

                    ins1.Cells[3].Value = "";
                    foreach (string day in edit.rDate)
                    {
                        ins1.Cells[3].Value += $"{day};";
                    }
                    ins1.Cells[4].Value = "";
                    foreach (DateTime time in edit.rTime)
                    {
                        ins1.Cells[4].Value += $"{time.ToString("hh:mm:ss tt")};";
                    }
                }
            }
            if (SoundDataGridView.SelectedRows.Count < 1 && SoundDataGridView.SelectedCells.Count < 6)
            {

                MessageBox.Show("โปรดเลือกแถว", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);

                /*
                 Form form = new Form();
                dynamic temx = null ;
                var typeOfData = SoundDataGridView.Columns[SoundDataGridView.SelectedCells[0].ColumnIndex].Name;
                switch (typeOfData)
                {
                    case "Active":
                        temx = new CheckBox();
                        temx.Parent = form;
                        temx.Dock = DockStyle.Top;
                        temx.Name = "permx";
                        temx.Checked = Convert.ToBoolean(SoundDataGridView.SelectedCells[0].Value);
                        break;
                    case "sName":
                        temx = new TextBox();
                        temx.Parent = form;
                        temx.Dock = DockStyle.Top;
                        temx.Name = "permx";
                        temx.Text = SoundDataGridView.SelectedCells[0].Value.ToString();
                        break;
                    case "File":
                        temx = new TextBox();
                        Button box  = new Button();
                        box.Parent = form;
                        box.Dock = DockStyle.Top;
                        box.Text = "...";
                        temx.Parent = form;
                        temx.Dock = DockStyle.Top;
                        temx.Name = "permx";
                        temx.Text = SoundDataGridView.SelectedCells[0].Value.ToString();
                        box.Click += (s, e1) => {
                            OpenFileDialog ofd = new OpenFileDialog();
                            ofd.Filter = "MP3 Files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav|Ogg Files (*.ogg)|*.ogg";
                            DialogResult dialogResult = ofd.ShowDialog();
                            if (dialogResult == DialogResult.OK)
                            {
                                temx.Text = ofd.FileName;
                            }
                        };
                        break;
                    case "Date":
                        temx = new Panel();
                        temx.
                        break;
                    case "AlertTime":
                        break;
                    case "Volume":
                        break;
                }




                form.StartPosition = FormStartPosition.CenterParent;
                form.Text = "แก้ไข";
                form.ShowIcon = false;
                form.MinimumSize = new Size(300, 200);
                form.Size = new Size(300, 200);
                form.ShowDialog(); */
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (SoundDataGridView.SelectedRows.Count > 0)
            {
                if (SoundDataGridView.SelectedRows[0].Cells[1].Value.ToString().Length <= 0)
                {
                    MessageBox.Show("โปรดเลือกแถวที่ต้องการก่อนลบ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SoundDataGridView.Rows.RemoveAt(SoundDataGridView.SelectedRows[0].Index);
                }
            }
        }

        private void SaveAndExitBtn_Click(object sender, EventArgs e)
        {
            iniFile = new classes.IniFile(appSetting.iniConfigfilePath);
            if (!Directory.Exists(appSetting.defaultSavePath))
            {
                Directory.CreateDirectory(appSetting.defaultSavePath);
            }
            dynamic[] stacks = appSetting.StartUpEnable(AutoRun.Checked);
            iniFile.Write(appSetting.defaultIniKey[0,0],AutoRun.Checked.ToString());
            iniFile.Write(appSetting.defaultIniKey[1, 0], trackBar1.Value.ToString());
            xml.WriteXML(SoundDataGridView, appSetting.defaultSavePath, appSetting.xmlConfigfileName);
            if (stacks[0])
            {
                MessageBox.Show($"บันทึกผิดพลาด\n{stacks[1]}");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            OverallSoundVolumeText.Text = $"ระดับเสียงโดยรวม : {trackBar1.Value}%";
        }
    }
}
