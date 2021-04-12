using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Expression_Parenthese
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = args[0];

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            

            for(int i=0;i<=9; i++)
                expression = expression.Replace(i.ToString(), "");

            for (char c = 'A'; c <= 'Z'; c++)
                expression = expression.Replace(c.ToString(),"");

            for (char c = 'a'; c <= 'z'; c++)
                expression = expression.Replace(c.ToString(), "");

            

           

            int nbExcecution = 0;
            while(expression.Length%2 == 0 && nbExcecution<20)
            {
               
                expression = expression.Replace("{}", "");             
                
                expression = expression.Replace("()", "");
                              
                expression = expression.Replace("[]", "");

                nbExcecution++;
            }
            


            if (expression.Length > 0) Console.WriteLine("false"); else Console.WriteLine("true");

            Console.WriteLine(expression);


            Console.ReadKey();
        }
    }
}
