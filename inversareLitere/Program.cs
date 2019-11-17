using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversareLitere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti cuvantul pentru a putea inversa prima litera cu ultima");
            string word = Console.ReadLine();
            string wordnou = word.Remove(0, 1);
            string wordnou2 = wordnou.Remove(wordnou.Length - 1,1);
            string word1 = string.Format("{0}"+wordnou2+"{1}", word.Substring(word.Length - 1), word.Substring(0, 1));
            Console.WriteLine(word1);
            Console.ReadLine();

        }
    }
}
