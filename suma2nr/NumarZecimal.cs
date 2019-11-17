using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma2nr
{
    public class NumarZecimal
    {
        public void Zecimal()
        {
            decimal a = 0.0m;
            decimal b = 1.0m;
            decimal c = 0.1m;
            decimal bround = Math.Round(b, 1);
            decimal sum3 = 0.0m;
            for (decimal i = Math.Round(a, 1); i <= bround; i = i + c)
            {
                sum3 = sum3 + i;
            }
            Console.WriteLine("suma dintre 0.0 si 1.0 este de "+sum3);
        }
    }
}
