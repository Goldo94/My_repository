﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ax1, bx1, ax2, bx2, e, min;
            Console.Write("a(x1) = ");
            ax1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b(x1) = ");
            bx1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a(x2) = ");
            ax2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b(x2) = ");
            bx2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("e = ");
            e = Convert.ToDouble(Console.ReadLine());
            if (ax1 > bx1)
            {
                Console.WriteLine("Неверно введены границы по х1");
                goto m1;
            }
            if (ax2 > bx2)
            {
                Console.WriteLine("Неверно введены границы по х2");
                goto m1;
            }

            min = Math.Pow(-ax1 * ax2, 3);
            for (double i = ax1; i <= bx1; i += e)
            {
                for (double j = ax2; i <= bx2; i += e)
                {
                    if (min > Math.Pow(-i * j, 3))
                        min = Math.Pow(-i * j, 3);
                }
            }
            Console.WriteLine("min = {0}", min);
        m1: Console.Read();

        }
    }
}
