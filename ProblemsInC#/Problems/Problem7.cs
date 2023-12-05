using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem7
    {
        static void Main(string[] args)
        {

            // Problem7 :  Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.


            Console.Write("Enter the first input: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second input: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            

        }
    }
}