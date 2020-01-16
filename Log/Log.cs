using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logger
{
    public class Log
    {
        private StringBuilder toFile = new StringBuilder();
        private List<string> toFile1 = new List<string>();
        private string timeStamp()
        {
            var ret = new DateTime();
            
            return "[" + DateTime.Now.ToString() + "]";
        }

        public string info(string str)
        {
            toFile.Append(timeStamp() + " [INFO] : " + str + "\n");
            toFile1.Add(timeStamp() + " [INFO] : " + str + "\n");
            return null;
        }

        public string emerg(string str)
        {
            toFile.Append(timeStamp() + " [EMERGENCY] : " + str + "\n");
            toFile1.Add(timeStamp() + " [EMERGENCY] : " + str + "\n");
            return null;
        }

        public string alert(string str)
        {
            toFile.Append(timeStamp() + " [ALERT] : " + str + "\n");
            toFile1.Add(timeStamp() + " [ALERT] : " + str + "\n");
            return null;
        }

        public string crit(string str)
        {
            toFile.Append(timeStamp() + " [CRITICAL] : " + str + "\n");
            toFile1.Add(timeStamp() + " [CRITICAL] : " + str + "\n");
            return null;
        }

        public string err(string str)
        {
            toFile.Append(timeStamp() + " [ERROR] : " + str + "\n");
            toFile1.Add(timeStamp() + " [ERROR] : " + str + "\n");
            return null;
        }

        public string warning(string str)
        {
            toFile.Append(timeStamp() + " [WARNING] : " + str + "\n");
            toFile1.Add(timeStamp() + " [WARNING] : " + str + "\n");
            return null;
        }

        public string notice(string str)
        {
            toFile.Append(timeStamp() + " [NOTICE] : " + str + "\n");
            toFile1.Add(timeStamp() + " [NOTICE] : " + str + "\n");
            return null;
        }

        public string debug(string str)
        {
            toFile.Append(timeStamp() + " [DEBUG] : " + str + "\n");
            toFile1.Add(timeStamp() + " [DEBUG] : " + str + "\n");
            return null;
        }

        public void generate(string path, char identifier)
        {
            switch (identifier)
            {
                case 'I':
                    File.AppendAllText(path+"log.log", toFile1.FindAll(f => f.Equals("INFO")).ToString());
                    break;

                case 'E':
                    File.AppendAllText(path+"log.log", toFile1.FindAll(f => f.Equals("EMERGENCY")).ToString());
                    break;

                default:
                    break;
            }

            // File.AppendAllText(path+"log.log", toFile.ToString());
            // toFile.Clear();
        }

        public void print()
        {
                
        }
    }
}