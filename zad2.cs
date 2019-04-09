using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad2
{
    class Program
    {
        public static double x1, x2, x3, X1, X2, X3, w, W, deltaX1, deltaX2, deltaX3;

        public static int A, B, C;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите дельта Х1");
            deltaX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите дельта Х2");
            deltaX2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите дельта Х3");
            deltaX3 = Convert.ToDouble(Console.ReadLine());
            W = 1000000;
            A = 1;
            B = 1;
            C = 5;
            for (x3 = 0; x3 <= C; x3 += deltaX3)
            for (x2 = 0; x2 <= A; x2 += deltaX2)
                for (x1 = 0; x1 <= B; x1 += deltaX1)
                {
                    if (5 * x1*x2 - x3*x3+ 4*x2 <= 20)
                        if (x1*x2*x2 -3*x3*x3+6*x2 <= 18)
                            if (x1*x2*x3 + 3 * (x1+x2+x3) <= 15)
                                if (x1 +  x2 +16*x3 <= 24)
                                {
                                    w = 3 * x1*x1 + 4 * x2*x2*x2-3*x3*x3;
                                    if (w < W)
                                    {
                                        W = w;
                                        X1 = x1;
                                        X2 = x2;
                                        X3 = x3;
                                    }
                                }
                }
            Console.WriteLine("W = " + W + " , x1 = " + X1 + " , x2 = " + X2 +  "  X3 = " + X3 );
            Console.ReadKey();
        }
    }
}