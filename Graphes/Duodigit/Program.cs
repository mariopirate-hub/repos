using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duodigit
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(Duodigit(1));  //1
            Console.WriteLine(Duodigit(-2021)); //0
            Console.WriteLine(Duodigit(9)); //1
            Console.WriteLine(Duodigit(33333)); //1
            Console.WriteLine(Duodigit(567)); //0

            Console.ReadKey();
        }
        static int Duodigit(int number)
        {
            List<string> lstA = new List<string>();
            if (number.ToString().Length == 1) return 1;

            else if (number > 0)

                lstA = StringToList(number.ToString());

            else

                lstA = StringToList(number.ToString().Substring(1, number.ToString().Length - 1));


            int cpt = 0;
            for (int i = 0; i < lstA.Count() - 1; i++)
            {
                if (lstA[i] != lstA[i + 1])
                {
                    cpt++;
                }
            }

            return cpt == 0 ? 1 : 0;
        }
        static List<string> StringToList(string mot)
        {

            List<string> result = new List<string>();

            for (int i = 0; i < mot.Length; i++)
            {
                result.Add(mot.Substring(i, 1));
            }

            return result;
        }


    }
}
