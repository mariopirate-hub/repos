using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fromid = new int[] { 4, 9, 6, 1, 5 };
            int[] toid = new int[] { 9, 5, 1, 4, 6 };
            int y = FindNetworkEndpoint(6, fromid, toid);
            Console.WriteLine("result = " + y);

            Console.ReadKey();
        }

        public static int FindNetworkEndpoint(int startNodeId, int[] fromIds, int[] toIds)
        {
                    
            if (fromIds.Contains(startNodeId))
            {
                int i = Array.IndexOf(fromIds, startNodeId);

                while ((toIds[i] != startNodeId) && (fromIds.Contains(toIds[i])))
                {

                    
                    i = Array.IndexOf(fromIds, toIds[i]);

                }
                return fromIds[i];
            }
            else
            {
                return startNodeId;
            }

            
            
        }

        
    }
}
