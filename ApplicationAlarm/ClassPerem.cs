using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace ApplicationAlarm
{
    public class ClassPerem
    {
        
        public string fileName = string.Empty;
       public  int hour = 0;
        public int minute = 0;
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hour = value;
                }
                else
                {

                    throw new Exception("Часы должны быть от 0 да 23");

                }



            }
        }

       public  int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minute = value;
                }
                else
                {

                    throw new Exception("Минуты должны быть от 0 да 59");

                }



            }
        }


       public  int indexHour = 1;
       public  int indexMinute = 1;
        public int[] massHours = new int[1];
       public  int[] massMinutes = new int[1];
        public bool btn = false;




        



        public void Save()
        {
            string filename = Global.SettingsFile;
            if (File.Exists(filename))
            {
                File.Delete(filename);

            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(ClassPerem));
                xser.Serialize(fs, this);
                fs.Close();
            }

        }

        public static ClassPerem GetClassPerem()
        {
            ClassPerem classPerem = null;
            string filename = Global.SettingsFile;
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(ClassPerem));
                    classPerem = (ClassPerem)xser.Deserialize(fs);

                    fs.Close();
                }

            }
            else
            {
                classPerem = new ClassPerem();

            }
            return classPerem;

        }

    }
}
