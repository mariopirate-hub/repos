using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] inputs = Console.ReadLine().Split(' ');
            int D = 1; //int.Parse(inputs[0]); //1
            int B = 4;//int.Parse(inputs[1]); //4
            string LEAFS = "2 -1 3 0"; //Console.ReadLine(); //2 -1 3 0

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            int man = Math.Max(D,B) ; //2

            Console.WriteLine(LEAFS.Substring(3, 1)); // 3 5
        }
    }
}
