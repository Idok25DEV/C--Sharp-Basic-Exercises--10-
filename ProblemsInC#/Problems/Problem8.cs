using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem8
    {
        static void Main(string[] args)
        {

            // Problem8 :  Write a C# Sharp program that prints the multiplication table of a number as input.


            Console.Write("Enter the input: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(x * 1);
            Console.WriteLine(x * 2);
            Console.WriteLine(x * 3);
            Console.WriteLine(x * 4);
            Console.WriteLine(x * 5);
            Console.WriteLine(x * 6);
            Console.WriteLine(x * 7);
            Console.WriteLine(x * 8);
            Console.WriteLine(x * 9);
            Console.WriteLine(x * 10);
            Console.ReadLine();
         


        }
    }
}