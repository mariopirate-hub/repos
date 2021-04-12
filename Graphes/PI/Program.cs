using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    class Point
    {
        public double x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var rands = new Point[100000];
            Random random = new Random();

            for (int i = 0; i < rands.Length; i++)
            {
                Point p = new Point();
                p.x = random.NextDouble(); //x
                p.y = random.NextDouble(); //y
                rands[i] = p;
            }

            double Test = Approx(rands);

            Console.WriteLine(Test);

            Console.ReadKey();
        }

        static double Approx(Point[] pts)
        {
            int v = 0;
            foreach (Point pt in pts)
            {
                if (((float)Math.Pow(pt.x, 2) + (float)Math.Pow(pt.y, 2)) <= 1)
                {
                    v++;
                }
            }
            return (4f * v / (float)pts.Length);

        }
    }
}
