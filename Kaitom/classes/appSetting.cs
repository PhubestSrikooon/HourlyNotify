using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string iniConfigfileName = "setting.ini";
        public string startUpBatchFile = "HourlyNotify.bat";
        public string xmlConfigfileName = "soundsave.xml";
        public string temp = $"{Path.GetTempPath()}//HoursNotify";
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
    }
}
