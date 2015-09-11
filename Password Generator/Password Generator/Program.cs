using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Password_Generator
{
    class Program
    {
        private static string PasswordCharacters = "abcdefgijkmnopqrstwxyzABCDEFGHJKLMNPQRSTWXYZ";
        private static string PasswordNumbers    = "0123456789";
        private static string PasswordSpecials   = "*$-+?_&=!%{}/";

        private static string temp               = string.Empty;
        private static int pwdLength             = 0;

        static void Main(string[] args)
        {
            string Options  = 
                            "Open Source Password Generator by Prashant M. Shrestha.\n" +
                            "Please type the length of password to generate 10 unique passwords.\n";

            Write(Options);

            temp            = Console.ReadLine();

            Int32.TryParse(temp, out pwdLength);

            Write(pwdLength + "");

            if(pwdLength > 0 && pwdLength < 25)
            {
                
            }
        }

        static void Write(string S)
        {
            Console.WriteLine(S);
        }
    }
}
