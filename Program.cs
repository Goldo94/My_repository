using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Методы_оптимизации_1
{
    class Program
    {
        public static double x1, x2, X1, X2, w, W, deltaX1, deltaX2, l1, l2;
        public static double[,] a = new double[4,2];
        public static double[] b = new double[4];
        public static int A, B;

        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Введите a" + (i+1) + (j+1));
                    a[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите b" + (i+1));
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите L1");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите L2");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите дельта Х1");
            deltaX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите дельта Х2");
            deltaX2 = Convert.ToDouble(Console.ReadLine());
            W = - 10 ^ 6;
            A = 100;
            B = 100;
            for (x2 = 0; x2 <= A; x2 += deltaX2)
                for (x1 = 0; x1 <= B; x1 += deltaX1)
                {
                    if (a[0,0] * x1 + a[0,1] * x2 <= b[0])
                        if (a[1,0] * x1 + a[1,1] * x2 <= b[1])
                            if (a[2,0] * x1 + a[2,1] * x2 <= b[2])
                                if (a[3, 0] * x1 + a[3, 1] * x2 <= b[3])
                                {
                                    w = l1 * x1 + l2 * x2;
                                    if (w > W)
                                    {
                                        W = w;
                                        X1 = x1;
                                        X2 = x2;
                                    }
                                }
                }
            Console.WriteLine("W = " + W + " , x1 = " + X1 + " , x2 = " + X2);
            Console.ReadKey();
        }
    }
}