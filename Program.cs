using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //tema 1 sa se dea exemple de variabile de mai multe tipuri
            int a = 1000;int b = 2000; int c = 3000;
            float af = 10.05f; float bf = 20.6f;float cf = 23f;
            long al = 50000l;long bl = 70005843l;long cl = 23057483;
            char ac = 'w';char bc = ',';char cc = '?';
            byte ab = 0;byte bb = 9;byte cb = 254;
            bool at = true; bool bt = false;bool ct = true;
            string ax = "string1";string bs = "string nou";string cs = "Acesta este un string declarat";
            double ad = 345.987;double bd = 5643d;double cd = -86632.5834;
            short ass = -5;short bss = -99;short css = 1244;
            decimal adx = 4635.76m;decimal bdx = 2736402.297457m;decimal cdx = -98745281698.098765m;

            //tema 2 , afiseaza Marian hello you
            Console.WriteLine("MArian"); Console.WriteLine("Hello you");

            //tema 3
            var asz = "string1"; var bsz = "string nou";var csz = "acesta este un exemplu de string in variabila";

            //tema 4
            Console.Write("MArian"); Console.WriteLine("Hello");

            //tema 5
            Console.WriteLine("introducetiva numele :");
            string nume = Console.ReadLine(); Console.WriteLine("Hello "+nume);

            //tema 6;
            var a1 = 5;var a2 = 8;var a3 = 9;var a4 = 12;var a5 = 99;
            int suma1 = a1 + a2 + a3 + a4 + a5;
            Console.WriteLine(suma1);

            //tema 7
            int sum2 = 0;
            Console.WriteLine("introduceti 5 numere pentru a calcula suma lor :");
            for (int ai = 0; ai < 5; ai++)
            {
                int a71 = Convert.ToInt32(Console.ReadLine());
                sum2 = a71+sum2;
                
            }
            Console.WriteLine(sum2);

            //tema8
            Console.WriteLine("calculam acum pe 4 linii :");
            Console.WriteLine(-1+4*6);
            Console.WriteLine((35+5)%7);
            Console.WriteLine(14+(-4)*6/11);
            Console.WriteLine(2+15/6*1-7%2);

            //tema9
            Console.WriteLine("introduceti 3 numere pentru a calcula produsul lor");
            int a91 = Convert.ToInt32(Console.ReadLine()); int a92 = Convert.ToInt32(Console.ReadLine()); int a93 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a91*a92*a93);

            // tema 10
            Console.WriteLine("introduceti 2 numere pentru a calcula suma/diferenta/produsul/impartirea si restul lor");
            int a101 = Convert.ToInt32(Console.ReadLine()); int a102 = Convert.ToInt32(Console.ReadLine());
            int suma10 = a101 + a102;int produs10 = a101 * a102;int diferenta10 = a101 - a102;int impartire10 = a101 / a102;int rest10 = a101 % a102;
            Console.WriteLine(" "+ suma10+" "+produs10+" "+diferenta10+" "+impartire10+" "+rest10);
            Console.ReadLine();

        }
    }
}
