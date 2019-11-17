using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma2nr
{
    public class NumarDeVocale
    {
        public void NumarVocale()
        {
            char[] c = { 'a', 'e', 'i', 'o', 'u' };
            string a = Console.ReadLine().ToLower().Trim();
            int xsum = 0;
            int xsum2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (c.Contains(a[i]))
                {
                    xsum ++;
                }
                if (!c.Contains(a[i]))
                {
                    xsum2++;
                }

            }
            Console.WriteLine("numarul de vocale este :"+xsum);
            Console.WriteLine("numarul de consoane din cuvant este de {0}!",xsum2);
        }
    }
}
