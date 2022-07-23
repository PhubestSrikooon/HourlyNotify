using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Kaitom.classes
{
    internal class XmlClass
    {
        XmlSerializer serializer;
        public void WriteXML(DataGridView dataGridView,string path,string fileName)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            serializer = new XmlSerializer(typeof(List<SoundInstanceClass>));
            List<SoundInstanceClass> list = new List<SoundInstanceClass>();
            FileStream fs = new FileStream($"{path}//{fileName}", FileMode.Create, FileAccess.Write);
            foreach(DataGridViewRow row in dataGridView.Rows) { 
                SoundInstanceClass soundInstanceClass = new SoundInstanceClass();
                soundInstanceClass.Active = Convert.ToBoolean(row.Cells[0].Value);
                soundInstanceClass.Name = row.Cells[1].Value.ToString();
                soundInstanceClass.File = row.Cells[2].Value.ToString();
                soundInstanceClass.Date = row.Cells[3].Value.ToString();
                soundInstanceClass.AlertTime = row.Cells[4].Value.ToString();
                soundInstanceClass.Volume =  Convert.ToInt32(row.Cells[5].Value.ToString());
                list.Add(soundInstanceClass);
            }
            serializer.Serialize(fs, list);
            fs.Close();
        }
        public List<SoundInstanceClass> ReadXML(string PathFile)
        {
            if (!File.Exists(PathFile))
            {
                return new List<SoundInstanceClass>();
            }
            if (!Directory.Exists(appSetting.Instance.temp))
            {
                Directory.CreateDirectory(appSetting.Instance.temp);
            }
            string rand = $"{appSetting.Instance.temp}//{new Random().Next(10000, 100000)}.tmp";
            File.Copy(PathFile, rand);
            serializer = new XmlSerializer(typeof(List<SoundInstanceClass>));
            List<SoundInstanceClass> list = new List<SoundInstanceClass>();
            FileStream fs = new FileStream(rand, FileMode.Open, FileAccess.Read);
            list = (List<SoundInstanceClass>)serializer.Deserialize(fs);
            fs.Close();
            File.Delete(rand);
            return list;
        }

    }
}
