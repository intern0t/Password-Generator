using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Options = 
                "Open Source Password Generator by Prashant M. Shrestha.\n" +
                "Please type the length of password to generate 10 unique passwords.\n";

            Write(Options);

            Console.Read();
        }

        static void Write(string S)
        {
            Console.WriteLine(S);
        }
    }
}
