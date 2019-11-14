using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "INtroduceti un numar pentru a afla daca este FizzBuzz :");
            int a22 = int.Parse(Console.ReadLine());
            if (a22 % 15 == 0)
            {
                Console.WriteLine("Avem un numar FizzBuzz !");
            }
            else if (a22%3==0)
            {
                Console.WriteLine("Avem un numar Fizz !");
            }
            else if(a22%5==0)
            {
                Console.WriteLine("Avem un numar Buzz !");
            }
            else
            {
                Console.WriteLine("Avem un numar non Fizz/Buzz");
            }

            Console.ReadLine();
        }
    }
}
