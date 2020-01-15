using System;
using System.Text;

namespace Chiper
{
    class Program
    {
        static void Main(string[] args)
        {
            Chiper cp = new Chiper();
            cp.Key = 15;
            cp.Pass = "jos";
            
            var encripted = cp.encrypt("aku adalah anak gembala selalu riang serta gembira", "jos");
            var decripted = cp.decrypt(encripted, "jos");
            Console.WriteLine($"hasil enkripsi {encripted}");
            Console.WriteLine($"hasil dekripsi {decripted}");
        }
    }

    class Chiper
    {
        private string pass;
        private int key;
        public string Pass
        {set{pass = value;}}
        public int Key
        {set{key = value;}}

        private bool validatePassword(string pass)
        {
            if(pass == this.pass)
                return true;

            else
                return false;
        }

        public string encrypt(string str, string pass)
        {
            if(validatePassword(pass))
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in str)
                {
                    if(Char.IsLetter(c))
                        sb.Append(Convert.ToChar(c + key));

                    else
                        sb.Append(c);
                    
                }

                return sb.ToString();
            }

            else
                return "password salah";
        }

        public string decrypt(string str, string pass)
        {
            if(validatePassword(pass))
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in str)
                {
                    if(c != ' ')
                        sb.Append(Convert.ToChar(c - key));
                    
                    else
                        sb.Append(c);
                }                   

                return sb.ToString();
            }

            else
                return "password salah";
        }
    }
}
