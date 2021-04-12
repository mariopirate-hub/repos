using System;
using System.Collections.Generic;
using System.Linq;

namespace reshape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reshape(3, "abc de fghij"));
            Console.WriteLine(Reshape(2, "1 23 456"));

            Console.ReadKey();
        }
        static String Reshape(int n, String str)
        {
            string strL = str.Replace(" ", string.Empty);
            int debut = 0;
            List<string> ChaineFinale = new List<string>();
          

            for (int i = 0; i < (strL.Length / n); i++)
            {
                ChaineFinale.Add(strL.Substring(debut, n));

                debut += n;
            }

            if (strL.Length % n != 0) ChaineFinale.Add(strL.Substring(debut, (strL.Length % n)));



            return string.Join("\n", ChaineFinale);
        }
    }
}
