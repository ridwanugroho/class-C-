using System;
using System.Text;

namespace Logger
{
    public class Log
    {
        private StringBuilder toFile = new StringBuilder();
        private string timeStamp()
        {
            return "time";
        }

        public string info(string str)
        {
            return timeStamp() + "[INFO] : " + str;
        }

        public string emerg(string str)
        {

        }

        public string alert(string str)
        {

        }

        public string crit(string str)
        {

        }

        public string err(string str)
        {

        }

        public string warning(string str)
        {

        }

        public string notice(string str)
        {

        }

        public string debug(string str)
        {

        }

        public void generate(string path)
        {
            File.AppendAllText(path+"log.txt", toFile.ToString());
        }

        public void print()
        {
                
        }
    }
}