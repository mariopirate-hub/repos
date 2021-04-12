using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norris
{
    class Program
    {
        static void Main(string[] args)
        {
            string MESSAGE = "C";//Console.ReadLine();

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            char ASCII = Convert.ToChar(MESSAGE);  // convert ASCII
            var binaire = Convert.ToString(ASCII, 2); // convert binaire

            string Norris = "";
            for (int i = 0; i < binaire.Length; i++)
            {
                if (i != 0)
                {
                    Norris += " ";
                }
                if (binaire.Substring(i, 1) == "1")
                {
                    Norris += "0";
                }
                else if (binaire.Substring(i, 1) == "0")
                {
                    Norris += "00";
                }
            }

            //int t = Norris.Contains("00").Count();

            Console.WriteLine(Norris);
        }
    }
}
