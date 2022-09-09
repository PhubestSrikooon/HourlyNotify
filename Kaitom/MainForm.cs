using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaitom
{
    public partial class MainForm : Form
    {
        public bool isPause = false;
        classes.XmlClass Xml = new classes.XmlClass();
        classes.IniFile Ini;
        classes.soundPlayInstance Sound = new classes.soundPlayInstance();
        classes.appSetting appSetting = classes.appSetting.Instance;
        List<classes.SoundInstanceClass> soundInstances;
        private void TimerTickVoid()
        {
            if (isPause) {
                statShow1.NextTime = "หยุดการทำงานชั่วคราว";
                statShow1.NowTime = DateTime.Now.ToString("hh:mm:ss tt");
                status.Text = $"สถานะ : หยุดการทำงานชั่วคราว";
                statShow1.Invalidate();
                return;
            }
            List<dynamic> lts1 = listOf2DayAlert();
            if (lts1.Count < 1)
            {
                statShow1.NextTime = "ไม่มีการแจ้งเตือน";
            }
            else
            {
                statShow1.NextTime = lts1[0][1].ToString("hh:mm:ss tt");
                //Console.WriteLine($"{(DateTime.Now.TimeOfDay - lts1[0][1].TimeOfDay).TotalSeconds} { lts1[0][3] * Convert.ToInt32(Ini.Read(appSetting.defaultIniKey[1, 0])) / 100}");
                if ((DateTime.Now.TimeOfDay - lts1[0][1].TimeOfDay).TotalSeconds > -0.1 ) 
                {
                    Sound.PlaySound(lts1[0][2], (lts1[0][3] * Convert.ToInt32(Ini.Read(appSetting.defaultIniKey[1, 0]))/100));
                }
            }
            statShow1.NowTime = DateTime.Now.ToString("hh:mm:ss tt");
            status.Text = $"สถานะ : เหลืออีก {lts1.Count} เสียงที่ยังไม่ทำงาน";
            statShow1.Invalidate();
        }

        private dynamic listOf2DayAlert()
        {
            List<dynamic> list = new List<dynamic>();
            if (soundInstances.Count > 0)
            {
                foreach (classes.SoundInstanceClass soundInstance in soundInstances)
                {
                    if (soundInstance.Active)
                    {
                        foreach (string t in soundInstance.Date.Split(';'))
                        {
                            if (t == "" || t == " ") { continue; }
                            if (DateTime.Now.DayOfWeek == appSetting.days[t])
                            {
                                dynamic atsplit = soundInstance.AlertTime.Split(';');
                                for (int i1 = 0;i1 < atsplit.Length;i1++)
                                {
                                    if (atsplit[i1] == "" || atsplit[i1] == " " || DateTime.ParseExact(atsplit[i1], "hh:mm:ss tt", CultureInfo.CurrentCulture).TimeOfDay < DateTime.Now.TimeOfDay) { continue; }
                                    if (!File.Exists(soundInstance.File)) { continue; }
                                    list.Add(new dynamic[]
                                    {
                                        soundInstance.Name,
                                        DateTime.ParseExact(atsplit[i1],"hh:mm:ss tt",CultureInfo.CurrentCulture),
                                        soundInstance.File,
                                        soundInstance.Volume,
                                    });
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0)
                {
                    if (list[i][1] < list[i - 1][1])
                    {
                        dynamic a = list[i];
                        dynamic b = list[i - 1];
                        list[i] = b;
                        list[i - 1] = a;
                        i = 0;
                    }
                }
            }
            return list;
        }
        public MainForm()
        {
            appSetting.checkUpdate(false);
            Xml = new classes.XmlClass();
            InitializeComponent();
            Ini = new classes.IniFile(appSetting.iniConfigfilePath);
            notifyIcon1.ShowBalloonTip(2);
            soundInstances = Xml.ReadXML(appSetting.xmlConfigfilePath);
            timeUpdate.Tick += (s,e) => TimerTickVoid();

            this.FormClosing += (s, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    this.Hide();
                    showhHideToolStripMenuItem.Text = "แสดง";
                    notifyIcon1.BalloonTipText = "ระบบแจ้งเตือนรายชั่วโมงได้เทำงานในพื้นหลัง";
                    notifyIcon1.ShowBalloonTip(2);

                }
            };
            showhHideToolStripMenuItem.Click += (s,e) => { 
                if (showhHideToolStripMenuItem.Text == "ซ่อน")
                {
                    showhHideToolStripMenuItem.Text = "แสดง";
                    this.Hide();
                    notifyIcon1.BalloonTipText = "ระบบแจ้งเตือนรายชั่วโมงได้เทำงานในพื้นหลัง";
                    notifyIcon1.ShowBalloonTip(2);
                }
                else
                {
                    showhHideToolStripMenuItem.Text = "ซ่อน";
                    this.Show();
                    notifyIcon1.BalloonTipText = "ระบบแจ้งเตือนรายชั่วโมงได้เริ่มทำงานแล้ว";
                    notifyIcon1.ShowBalloonTip(2);
                }
            };
            updateCheckToolStripMenuItem.Click += (s, e) =>
            {
                appSetting.checkUpdate(true);
            };
            isPauseCheck.CheckedChanged += (s, e) =>
            {
                isPause = isPauseCheck.Checked;
            };
            AboutToolStripMenuItem.Click += (s, e) => {
                SubForm.About about = new SubForm.About();
                about.ShowDialog();
            };
            emergencystop.Click += (s, e) =>
            {
                Sound.StopAllSound();
            };
            exitContex.Click += (s, e) =>
            {
                Application.Exit();
            };
        }

        private void setting_Click(object sender, EventArgs e)
        {
            SubForm.SettingForm settingForm = new SubForm.SettingForm();
            settingForm.TopLevel = true;
            DialogResult dialog = settingForm.ShowDialog();
            if (dialog == DialogResult.OK || dialog == DialogResult.Cancel)
            {
                soundInstances = Xml.ReadXML(appSetting.xmlConfigfilePath);
            }
        }
    }
}
