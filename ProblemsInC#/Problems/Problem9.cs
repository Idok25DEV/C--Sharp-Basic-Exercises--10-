using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem9
    {
        static void Main(string[] args)
        {

            // Problem9 :  Write a C# Sharp program that takes four numbers as input to calculate and print the average.


            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the four number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int res = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}