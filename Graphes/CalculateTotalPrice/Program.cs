using System;
using System.Linq;

namespace CalculateTotalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 100, 400, 200 };
            Console.WriteLine(CalculateTotalPrice(prices,20));

            Console.ReadKey();
        }
        static int CalculateTotalPrice(int [] prices,int discount)
        {
           
            double produitReduc  = prices.Max() - (prices.Max() * (double)discount / 100);

            double somme = prices.Sum() + produitReduc - prices.Max();
        
            return Convert.ToInt32(Math.Floor(somme));
        }
    }
}
