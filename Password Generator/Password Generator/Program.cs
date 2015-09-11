using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Password_Generator
{
    class Program
    {
        private static string PasswordCharacters    = "abcdefgijkmnopqrstwxyzABCDEFGHJKLMNPQRSTWXYZ0123456789*$-+?_&=!%{}/";
        private static string temp                  = string.Empty;
        private static int pwdLength                = 0;

        static void Main(string[] args)
        {
            Console.Title = "Random Password Generator - NonInfectio.us!";

            Write("Open Source Password Generator by Prashant M.Shrestha (Scarecrow) - www.noninfectio.us\n");

            string Options = "Please type the length of password to generate 10 unique passwords.";

            do
            {
                while (!Console.KeyAvailable)
                {
                    Write(Options);

                    temp = Console.ReadLine();

                    Int32.TryParse(temp, out pwdLength);

                    Console.ForegroundColor = ConsoleColor.Green;

                    if (pwdLength > 0 && pwdLength <= 128)
                    {
                        // Generate a password ..
                    }
                    else { Write("Please have the password length be 1-128." + Environment.NewLine); }

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void Write(string S)
        {
            Console.WriteLine(S);
        }
    }
}