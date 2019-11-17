using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma2nr
{
    class Program
    {

        //calculeaza suma a 2 numere, iar daca cele 2 numere sunt identice -inmultestele cu numarul 3
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti 2 numere pentru a le calcula suma lor :");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a!=b)
            {
                sum = a + b;
            }
            else
            {
                //sum = 3 * (a + b);
                sum=6*a;
            }
            Console.WriteLine(sum);

            Console.WriteLine("introduceti un text pentru a fi transformat in majuscule si minuscule: ");
            OperatieString text1 = new OperatieString();
            text1.Text();
            Console.WriteLine("introduceti un cuvant pentru a putea numara vocalele din el :");
            NumarDeVocale vocale = new NumarDeVocale();
            vocale.NumarVocale();

            NumarZecimal zec =new NumarZecimal();
            zec.Zecimal();

            Console.WriteLine("introduceti 2 numere pentru a afla toate numerele pare sau impare din acest sir !");
            NumerePare imPar = new NumerePare();
            imPar.NumereParImpar();

            Console.ReadLine();
        }

        
    }
}
