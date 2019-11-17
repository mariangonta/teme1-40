using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma2nr
{
    class NumerePare
    {
        public void NumereParImpar()
        {

            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a>=b)
            {
                Console.WriteLine("primul numar nu poate fi mai mare sau egal cu al doilea |:");
            }
            
            {
                for (int i = a; i <=b; i++)
                {
                    if (i%2==0)
                    {
                        Console.Write("numarul par ale sirului este urmatorul :"+i);
                    }
                    else
                    {
                        Console.WriteLine("  numarul impar ale sirului este urmatorul :"+i);
                    }
                }
            }

        }
    }
}
