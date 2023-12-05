using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem6
    {
        static void Main(string[] args)
        {

            // Problem6 :  Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            // Exm: 2 x 3 x 6 = 36


            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int resualt = num1 * num2 * num3;
            Console.WriteLine();
            Console.WriteLine(resualt);
            Console.ReadLine();
        }
    }
}