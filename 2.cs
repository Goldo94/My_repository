using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double a, c, x1, x2, E;

        static void Main(string[] args)
        {
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("E = ");
            E = Convert.ToDouble(Console.ReadLine());

            while (((x2 - x1) / 2) > E)
            {
                if (Func(0.61803 * x1 + 0.38197 * x2) < Func(0.38197 * x1 + 0.61803 * x2))
                    x2 = 0.38197 * x1 + 0.61803 * x2;
                else
                    x1 = 0.61803 * x1 + 0.38197 * x2;
            }

            Console.WriteLine("y = " + Func((x2 + x1) / 2));
            Console.Read();
        }

        static double Func(double p)
        {
            return (p * p - 2 * a * p + c);
        }
    }
}