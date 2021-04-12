using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MiniMax
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "24";
            string y = x;

            int[] subs = new int[x.Length];
            int nbexcecution = 0;
            int somme = 0;

            while (somme != 1 && nbexcecution < 10)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    
                    subs[i] = (int)(Math.Pow(int.Parse(x.Substring(i, 1)), 2));
                }

                somme = (int)subs.Sum(c => c);

                x = somme.ToString();

                nbexcecution++;

                subs = new int[x.Length];

            }



            Console.WriteLine(y + (somme == 1 ? " :)" : " :("));


            Console.ReadKey();
        }
    }
}

