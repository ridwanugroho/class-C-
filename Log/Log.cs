using System;
using System.Text;
using System.IO;

namespace Logger
{
    public class Log
    {
        private StringBuilder toFile = new StringBuilder();
        private string timeStamp()
        {
            return DateTime.Now.ToString();
        }

        public string info(string str)
        {
            toFile.Append(timeStamp() + " [INFO] : " + str + "\n");
            return null;
        }

        public string emerg(string str)
        {
            toFile.Append(timeStamp() + " [EMERGENCY] : " + str + "\n");
            return null;
        }

        public string alert(string str)
        {
            toFile.Append(timeStamp() + " [ALERT] : " + str + "\n");
            return null;
        }

        public string crit(string str)
        {
            toFile.Append(timeStamp() + " [CRITICAL] : " + str + "\n");
            return null;
        }

        public string err(string str)
        {
            toFile.Append(timeStamp() + " [ERROR] : " + str + "\n");
            return null;
        }

        public string warning(string str)
        {
            toFile.Append(timeStamp() + " [WARNING] : " + str + "\n");
            return null;
        }

        public string notice(string str)
        {
            toFile.Append(timeStamp() + " [NOTICE] : " + str + "\n");
            return null;
        }

        public string debug(string str)
        {
            toFile.Append(timeStamp() + " [DEBUG] : " + str + "\n");
            return null;
        }

        public void generate(string path)
        {
            File.AppendAllText(path+"log.log", toFile.ToString());
            toFile.Clear();
        }

        public void print()
        {
                
        }
    }
}