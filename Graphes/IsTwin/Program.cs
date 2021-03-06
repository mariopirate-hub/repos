using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTwin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTwin("Hello", "world")); //Faux 372 392
            Console.WriteLine(IsTwin("acb", "bca")); // Vrai
            Console.WriteLine(IsTwin("Lookout", "Outloook")); //Vrai

            Console.ReadKey();
        }

        public static bool IsTwin(String a, String b)
        {
            int asciiA = 0;
            int asciiB = 0;
            for (int i = 0; i < a.Length ; i++)           
                for (char c = 'A'; c <= 'Z'; c++)
                    if (a.Substring(i, 1).ToUpper().Contains(c)) asciiA += c;
                            
            for (int i = 0; i < b.Length ; i++)            
                for (char c = 'A'; c <= 'Z'; c++)
                    if (b.Substring(i,1).ToUpper().Contains(c)) asciiB += c;
                           
            return asciiA == asciiB ? true : false;
        }


    }
}
