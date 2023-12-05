using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem4
    {
        static void Main(string[] args)
        {

            // Problem 4:  Write a C# Sharp program to print the results of the specified operations.
            //  Test data:
            //   -1 + 4 * 6
            //   (35 + 5) % 7
            //   14 + -4 * 6 / 11
            //   2 + 15 / 6 * 1 - 7 % 2


            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine();
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine();
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine();
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}