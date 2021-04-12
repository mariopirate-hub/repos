using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreMagique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = new List<int>(new int[] { 1, 1 });
            Console.WriteLine(Magic(stones));//1

            stones = new List<int>(new int[] { 1, 1, 5 });
            Console.WriteLine(Magic(stones));//2

            stones = new List<int>(new int[] { 1, 1, 2, 3, 3, 3, 5, 6, 6, 6, 6, 6, 6, 6, 6, 9 });
            Console.WriteLine(Magic(stones));//2

            Console.ReadKey();
        }


        static int Magic(List<int> stones)
        {

            int j = 0;
            int nbstones = stones.Count();
            var numQuery = new List<bool>();


            int p1 = stones[j];

            do
            {


                foreach (int t in stones)
                {
                    numQuery = (from st in stones
                                where st.Equals(t)
                                select stones.Count() >= 2).ToList();

                    if (numQuery.Count() > 1)
                    {
                        j = Array.IndexOf(stones.ToArray(), t);
                        p1 = stones[j];
                        break;
                    }
                }




                for (int i = j + 1; i < stones.Count(); i++)
                {
                    if (p1 == stones[i])
                    {
                        stones.RemoveAt(i);
                        stones.RemoveAt(j);
                        p1++;
                        stones.Add(p1);
                        break;

                    }
                }

                foreach (int t in stones)
                {
                    numQuery = (from st in stones
                                where st.Equals(t)
                                select stones.Count() >= 2).ToList();

                    if (numQuery.Count() > 1) break;
                }


            } while (stones.Count() >= 2 && numQuery.Count() > 1);




            return stones.Count();
        }

    }
}
