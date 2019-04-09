using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double a, c, x1, x2, C, D, xx, y;
        static double e;

        static void Main()
        {
            
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("e = ");
            e = Convert.ToDouble(Console.ReadLine());
            while ((x2 - x1) / 2 > e) 
            {
                xx = (x2 + x1) / 2;
                C = xx - e / 2;
                D = xx + e / 2;

                if ((C * C - 2 * a * C + c) < (D * D - 2 * a * D + c))
                    x2 = D;
                else
                    x1 = C;
                Console.WriteLine("x1 = " + x1 + "; x2 = " + x2);
            }
            xx = (x2 + x1) / 2;
            y = xx * xx - 2 * a * xx + c;

            Console.WriteLine("y = " + y + "; x = " + xx);
            Console.ReadLine();

        }
    }
}
