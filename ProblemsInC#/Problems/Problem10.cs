using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    class Problem10
    {
        static void Main(string[] args)
        {

            // Problem 4:  Build DataBase without sql (Simpale)
            // 1 Name
            // 2 Last name
            // 3 Age 
            // 4 Born year 
            // 5 Fav Singer

            Console.WriteLine("Data: ");
            
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            
            Console.Write("What is your last name? ");
            string ltname = Console.ReadLine();
            
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What is your Born year? ");
            int born = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What is your Faviorte Singer? ");
            string fav = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your last name is " + ltname);
            Console.WriteLine("You are " + age + "years old.");
            Console.WriteLine("You born in " + born);
            Console.WriteLine("Your faviorte singer is " + fav);

            Console.ReadLine();


        }
    }
}