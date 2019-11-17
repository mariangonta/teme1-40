using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema11_20
{
    class Program
    {
        static void Main(string[] args)
        {//tema 11
            Console.WriteLine("introduceti un numar pentru tabla inmultirii pana la 10: ");
            int a11 = Convert.ToInt32(Console.ReadLine());
            int prod11 = 1;

            for (int i = 1; i <= 10; i++)
            {
                prod11 = a11 * i;
                Console.WriteLine(prod11);
            }

            //tema 12
            Console.WriteLine("introduceti 4 numere pentru a calcula media lor :");
            int a112 = Convert.ToInt32(Console.ReadLine()); int a212 = Convert.ToInt32(Console.ReadLine()); int a312 = Convert.ToInt32(Console.ReadLine()); int a412 = Convert.ToInt32(Console.ReadLine());

            int medie12 = (a112 + a212 + a312 + a412) / 4;
            Console.WriteLine(medie12);

            //tema 13
            Console.WriteLine("introduceti va rog varsta voastra ");
            int a13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("aratati mai tanar decat "+ a13+ " varsta dumneavoastra");

            //tema 14
            Console.Write("introduceti un caracter de la tastatura pentru a fi afisat in moduri diferite :");
            char a14 = Console.ReadKey().KeyChar;
            Console.WriteLine(" " + a14 + " " + a14 + " " + a14 + " " + a14);
            Console.WriteLine($" ", a14, " ", a14, " ", a14, " ", a14);
            Console.WriteLine($" {0} {0} {0} {0}", a14);

            //tema15
            //tema 14
            Console.Write("introduceti un caracter de la tastatura pentru a fi afisat in moduri diferite :");
            char a15 = Console.ReadKey().KeyChar;
            Console.WriteLine("" + a15 + "" + a15 + "" + a15 + "" + a15);
            Console.WriteLine($"", a15, "", a15, "", a15, "", a15);
            Console.WriteLine($"{0}{0}{0}{0}", a15);

            //tema16
            Console.Write("introduceti temperatura in grade celsius :");
            int a16 = Convert.ToInt32(Console.ReadLine());
            int grKelvin = a16 + 273; int grfah = a16 + 32;
            Console.WriteLine("gradele celsius "+ a16+ " in kelvin sunt "+ grKelvin+ " iar in fahrain, sunt  "+ grfah);

            Console.ReadLine();

            //tema 17
            Console.WriteLine("introduceti 2 numere de la tastatura pentru a le compara intre ele :");
            int a171 = Convert.ToInt32(Console.ReadLine()); int a172 = Convert.ToInt32(Console.ReadLine());
            if (a171==a172)
            {
                Console.WriteLine("cele 2 numere introduse sunt egale intre ele !");
            }
            else if (a171>a172)
            {
                Console.WriteLine("primul numar este mai mare  decat al doilea numar introdus! ");
            }
            else
            {
                Console.WriteLine("al doilea numar introdus este mai mare decat primul!");
            }

            // tema 18 par impar numar
            Console.WriteLine("introduceti un numar intreg pentru a stabili daca este par sau impar :");
            int a18 = Convert.ToInt32(Console.ReadLine());
            if (a18%2==0)
            {
                Console.WriteLine("Numarul introdus este par !");
            }
            else
            {
                Console.WriteLine("Numarul introdus este impar !");
            }

            // tema 19
            Console.WriteLine("introduceti un numar  pentru a stabili daca este pozitiv sau negativ :");
            int a19 = Convert.ToInt32(Console.ReadLine());
            if (a19 >= 0)
            {
                Console.WriteLine("Numarul introdus este mai mare decat zero !");
            }
            else
            {
                Console.WriteLine("Numarul introdus este mai mic decat zero !");
            }

            // tema20 program magazin
            Console.WriteLine("introduceti o ora pentru a stabili daca magazinul este deschis sau inchis, ora + minut :");
            int ora = int.Parse(Console.ReadLine());
            int minut = int.Parse(Console.ReadLine());
            if (ora>=9 &&ora<22 && minut>=0&&minut<60)
            {
                Console.WriteLine("Magazinul este deschis pentru cumparaturi !");
            }
            else if ((ora < 9 && ora > 22 && ora<24 && minut >= 0 && minut < 60))
            {
                Console.WriteLine("magazinul este inchis !");
            }
            else
            {
                Console.WriteLine("nu a fost introdusa o ora corespunzatoare pentru un ceas !");
            }
            Console.ReadLine();
        }
    }
}
