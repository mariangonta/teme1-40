using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma2nr
{
    public class OperatieString
    {
        public void Text()
        {
            
            string text = Console.ReadLine();
            string textM = text.ToUpper();
            string textm = textM.ToLower();
            Console.WriteLine("cuvantul scris in majuscule este {0} si in minuscule este {1}",textM,textm);

        }
    }
}
