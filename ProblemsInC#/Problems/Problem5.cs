using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem5
    {
        static void Main(string[] args)
        {

            // Problem5 : Write a C# Sharp program to swap two numbers.

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("The first number: " + num2);
            Console.WriteLine("The second number: " + num1);
            Console.ReadLine();
        }
    }
}