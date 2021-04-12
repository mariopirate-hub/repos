using System;
using System.Collections.Generic;
using System.Linq;

namespace PierreMagique_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = new List<int>(new int[] { 1, 1, 2, 3, 3, 3, 5, 6, 6, 6, 6, 6, 6, 6, 6, 9 });
            Console.WriteLine(Magic(stones));//2

            Console.ReadKey();
        }

        static int Magic(List<int> stones)
        {
            int old = stones.Count + 1;
            while (old != stones.Count)
            {
                old = stones.Count;
                for (int i = 1; i <= stones.Count - 1; i++)
                {
                    if (stones[^i] == stones[^(i + 1)])
                    {
                        stones[^(i + 1)]++;
                        stones.RemoveAt(stones.Count - i);
                    }
                }
            }
            ///////////////////
            ///OU
            /// var stones = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (stones.GroupBy(i => i).Any(i => i.Count() > 1))
            {
                var key = stones.GroupBy(i => i).OrderByDescending(i => i.Count()).First().Key;
                stones.Remove(key);
                stones.Remove(key);
                stones.Add(key + 1);
            }

            return stones.Count();
        }
    }
}
