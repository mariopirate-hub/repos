using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            string sortie = "";
            string[,] poid = new string[n,n];

            List<string> branche = new List<string>() { "A > B", "B > C" };

            List<string> Entree = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string row = branche[i];

                Entree.Add(row);
            }

            foreach (string r in Entree)
            {
                poid[0, 0] = r.Substring(0,1); //A
                poid[0, 1] = n.ToString(); //2
              

                if(r.Substring(2,1) == ">")
                {
                    poid[1, 0] = r.Substring(4,1); //B
                    poid[1, 1] = (int.Parse(poid[0, 1]) - 1).ToString();
                }
                else if(r.Substring(2,1) == "<")
                {
                    poid[1, 0] = r.Substring(4,1); //B
                    poid[1, 1] = (int.Parse(poid[0, 1]) + 1).ToString(); //n+1
                }
            }

            if ( int.Parse(poid[0, 1]) > int.Parse(poid[1, 1]))
            {
                sortie = "consistent";
            }
            else
            {
                sortie = "contradiction";
            }


            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(sortie);

            Console.ReadKey();
        }
    }
}
