using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Entree = new List<string> { "A....", ".....",".....", "....." , "....." };
            List<string> Entree1 = new List<string>{".....", "A....", ".....", ".....", "....." };

            List<string> LstT1 = new List<string>();
            List<string> LstT2 = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                
                string firstPictureRow = Entree[i];
                string secondPictureRow = Entree1[i];

                for (int j = 0; j < firstPictureRow.Length; j++)
                {
                    LstT1.Add(firstPictureRow.Substring(j, 1));
                }

                for (int j = 0; j < secondPictureRow.Length; j++)
                {
                    LstT2.Add(secondPictureRow.Substring(j, 1));
                }

            }

            List<int> cpt = new List<int>();
            for (int i = 0; i < LstT1.Count(); i++)
            {
                if (LstT1[i] == "A") cpt.Add(i);
            }

            for (int i = 0; i < LstT2.Count(); i++)
            {
                if (LstT2[i] == "A") cpt.Add(i);
            }

           
           for (int im = 0;im < 5 * 5;im++)
            {
                if (im % 5 == 0 && im != 0) Console.WriteLine();

                if (im == cpt.Sum()+1) Console.Write("A");
                else Console.Write(".");

            }


            Console.ReadKey();


        }

       


       





    }
}
