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
        private List<string> _filter = new List<string>();
        private bool _filterStat = false;

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

        public void generate(string path)
        {
            // print(toFile1);
            if(_filterStat)
            {
                TextWriter tw = new StreamWriter(path+"log1.log");
                foreach (String s in filter(_filter))
                    tw.Write(s);

                tw.Close();
            }

            else
            {
                TextWriter tw = new StreamWriter(path+"log1.log");
                foreach (String s in toFile1)
                    tw.Write(s);

                tw.Close();
            }
        }

        public void setFilter(params string[] filter)
        {
            if(filter[0] == "NONE")
                _filterStat = false;

            else
            {
                foreach (var s in filter)
                {
                    _filter.Add(s);
                }
                _filterStat = true;
            }
        }

        private List<string> filter(List<string> fil)
        {
            List<string> filtered = new List<string>();
            foreach (var f in fil)
            {
                Console.WriteLine("filter : {0}", f);
                foreach (var s in toFile1)
                {
                    if(s.Contains(f))
                    {
                        filtered.Add(s);
                    }
                }
            }

            return filtered;
        }

        public void print(List<string> data)
        {
            foreach (var l in data)
            {
                Console.WriteLine(l);
            }
        }
    }
}