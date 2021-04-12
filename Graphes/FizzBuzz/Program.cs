using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            map[3] = "FIZZ";
            map[4] = "BUZZ";

            Console.WriteLine(FizzBuzz(5, map)); //5
            Console.WriteLine(FizzBuzz(3, map)); //FIZZ
            Console.WriteLine(FizzBuzz(8, map)); //BUZZ
            Console.WriteLine(FizzBuzz(12, map)); //FIZZBUZZ

        }

        static String FizzBuzz(int number,Dictionary<int,string> map)
        {
            foreach(KeyValuePair<int,string> entry in map)
            {

            }
            return "";
        }
    }
}
