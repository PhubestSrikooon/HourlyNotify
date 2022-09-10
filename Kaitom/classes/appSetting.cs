using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaitom.classes
{
    internal class appSetting
    {
        static classes.appSetting _obj;


        public static classes.appSetting Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new classes.appSetting();
                }
                return _obj;
            }
        }

        public dynamic defaultLang = new Dictionary<string, string>
        {
            {"AppName","ระบบแจ้งเตือนรายชั่วโมง"},
            {"NowTime","เวลาตอนนี้"},
            {"NextTime","การแจ้งเตื่อนครั้งถัดไป"},
            {"Setting","การตั่งค่า"},
            {"AutoStartUp","เริ่มต้นอัตโนมัติตอนเปิดเครื่อง"},
            {"OverallVolume","ระดับเสียงโดยรวม"},
        };
        public dynamic days = new Dictionary<string, dynamic>
        {
            {
                "วันจันทร์",
                DayOfWeek.Monday
            },
            {
                "วันอังคาร",
                DayOfWeek.Tuesday
            },
            {
                "วันพุธ",
                DayOfWeek.Wednesday
            },
            {
                "วันพฤหัสบดี",
                DayOfWeek.Thursday
            },
            {
                "วันศุกร์",
                DayOfWeek.Friday
            },
            {
                "วันเสาร์",
                DayOfWeek.Saturday
            },
            {
                "วันอาทิตย์",
                DayOfWeek.Sunday
            },
        };
        public dynamic[,] defaultIniKey = new dynamic[,] {
            {
                "AutoStart",
                false
            },
            {
                "OverallVolume",
                80
            },
        };

        public int version = 2;
        public string vCheckPath = "https://raw.githubusercontent.com/PhubestSrikooon/HourlyNotify/master/Kaitom/version.txt";
        public Uri vDownloadLink = new Uri("https://raw.githubusercontent.com/PhubestSrikooon/HourlyNotify/master/Kaitom/downloadlink.txt");
        public string iniConfigfileName = "setting.ini";
        public string startUpBatchFile = "HourlyNotify.bat";
        public string xmlConfigfileName = "soundsave.xml";
        public string temp = $"{Path.GetTempPath()}//HoursNotify";
        public string updatebatchfilename = "update.bat";
        public string defaultstartUpPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}";
        public string defaultSavePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}//HoursNotify";
        public string iniConfigfilePath;
        public string xmlConfigfilePath;
        public string startUpFilePath;
        public appSetting()
        {
            xmlConfigfilePath = $"{defaultSavePath}//{xmlConfigfileName}";
            iniConfigfilePath = $"{defaultSavePath}//{iniConfigfileName}";
            startUpFilePath = $"{defaultstartUpPath}//{startUpBatchFile}";

        }

        public dynamic StartUpEnable(bool val)
        {
            try
            {
                if (val)
                {
                    if (!File.Exists(startUpFilePath))
                    {
                        var file = File.Create(startUpFilePath);
                        file.Close();
                    }
                    StreamWriter sw = new StreamWriter(startUpFilePath);
                    sw.Write("@echo off\n" +
                        $"start {System.Reflection.Assembly.GetExecutingAssembly().Location}");
                    sw.Close();
                }
                else
                {
                    if (File.Exists(startUpFilePath))
                    {
                        File.Delete(startUpFilePath);
                    }
                }
                return new dynamic[] { false, null };

            }
            catch (Exception ex)
            {
                return new dynamic[] { true, ex };
            }
        }

        public bool isInternetConnect()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

        public void checkUpdate(bool checkNet)
        {


            try
            {
                Form df = new Form();
                ProgressBar pb = new ProgressBar();
                Label lbl = new Label();
                Button dl = new Button();
                Button close = new Button();
                df.Width = 300;
                df.Height = 100;
                df.Text = "Updater";
                df.FormBorderStyle = FormBorderStyle.FixedSingle;
                pb.Parent = df;
                pb.Dock = DockStyle.Bottom;
                lbl.Parent = df;
                lbl.Text = "Checking update";
                dl.Parent = df;
                dl.Text = "Download";
                dl.Location = new Point(df.Width - dl.Width - 20, dl.Location.Y);
                close.Parent = df;
                close.Text = "Cancel";
                close.Click += (s, e) => { df.Close(); };
                close.Location = new Point(df.Width - dl.Width - 25 - close.Width, close.Location.Y);
                df.Show();
                df.StartPosition = FormStartPosition.CenterParent;


                void vDownload(string url, string filename)
                {

                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler((o, e) => {
                        if (e.Error == null)
                        {
                            lbl.Text = "ดาวโหลดสำเร็จ";
                            FileStream epix = File.Create(updatebatchfilename);
                            epix.Close();
                            StreamWriter sw = new StreamWriter(updatebatchfilename);
                            sw.Write("@echo off\n" +
                                $"taskkill /f /im {Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\n" +
                                $"timeout 1\n"+
                                $"del {System.Reflection.Assembly.GetExecutingAssembly().Location}\n" +
                                $"ren {filename} {Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location)} \n"+
                                $"start {System.Reflection.Assembly.GetExecutingAssembly().Location} \n");
                            sw.Close();
                            Process.Start(updatebatchfilename);

                        }
                        else
                        {
                            throw e.Error;
                        }
                        
                        ((WebClient)o).Dispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    });
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler((o, e) => {
                        pb.Value = e.ProgressPercentage;
                        lbl.Text = $"{e.ProgressPercentage}%";





                    });
                    webClient.DownloadFileAsync(new Uri(url), filename);

                }

                if (checkNet)
                {
                    if (!isInternetConnect())
                    {
                        lbl.Text = "No internet";
                        throw new Exception("Couldn't check update because no internet connection.");
                    }
                    else
                    {
                        if (new WebClient().DownloadString(vCheckPath).Contains(version.ToString()))
                        {
                            lbl.Text = "ไม่พบการอัพเดท";
                            dl.Enabled = false;
                        }
                        else
                        {
                            lbl.Text = $"version : {new WebClient().DownloadString(vCheckPath)}";
                            dl.Enabled = true;
                            dl.Click += (s, e) => {

                                vDownload(new WebClient().DownloadString(vDownloadLink), "app.exe");
                            };
                        }
                    }
                }
                else
                {
                    if (isInternetConnect())
                    {
                        if (!new WebClient().DownloadString(vCheckPath).Contains(version.ToString()))
                        {
                            lbl.Text = $"version : {new WebClient().DownloadString(vCheckPath)}";
                            dl.Enabled = true;
                            dl.Click += (s, e) => {

                                vDownload(new WebClient().DownloadString(vDownloadLink), "app.exe");
                            };
                        }
                        else
                        {
                            df.Close();

                        }
                    }
                    else
                    {
                        df.Close();
                    }

                }



            }
            catch (Exception ex)
            {
                SubForm.ErrorForms error1 = new SubForm.ErrorForms("Error", "มีข้อผิดพลาดเกิดขึ้น", ex);
                error1.ShowDialog();
            }
        }
    }
}
