using System;
using System.Security.Cryptography;
using System.Text;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash hs = new Hash();
            Console.WriteLine("MD5 : {0}", hs.md5("secret"));
            Console.WriteLine("SHA1 : {0}", hs.sha1("secret"));
            Console.WriteLine("SHA256 : {0}", hs.sha256("secret"));
            Console.WriteLine("SHA512 : {0}", hs.sha512("secret"));
        }
    }

    public class Hash
    {
        private string generateStrHash(byte[] byteHash)
        {
            StringBuilder ret = new StringBuilder();
            foreach (var b in byteHash)
            {
                ret.Append(b.ToString("X2"));
            }

            return ret.ToString().ToLower();
        }
        public string md5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] inpByte = Encoding.ASCII.GetBytes(str);
            byte[] hashByte = md5.ComputeHash(inpByte);

            return generateStrHash(hashByte);
        }

        public string sha1(string str)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inpByte = Encoding.ASCII.GetBytes(str);
            byte[] hashByte = sha1.ComputeHash(inpByte);
            
            return generateStrHash(hashByte);
        }

        public string sha256(string str)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inpByte = Encoding.ASCII.GetBytes(str);
            byte[] hashByte = sha256.ComputeHash(inpByte);
            
            return generateStrHash(hashByte);
        }

        public string sha512(string str)
        {
            SHA512 sha512 = new SHA512Managed();
            byte[] inpByte = Encoding.ASCII.GetBytes(str);
            byte[] hashByte = sha512.ComputeHash(inpByte);
            
            return generateStrHash(hashByte);
        }
    }
}
