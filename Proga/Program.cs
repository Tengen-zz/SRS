using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace integral
{
    class Program
    {
        static double integsqrt(double a,double b)
        {
            double s1, s2;
            s1 = (a / 2) * Math.Sqrt(a * a + 1) + 0.5 * Math.Log(a + Math.Sqrt(a * a + 1));
            s2 = (b / 2) * Math.Sqrt(b * b + 1) + 0.5 * Math.Log(b + Math.Sqrt(b * b + 1));
            return s1 - s2;
        }
        static void Main(string[] args)
        {
            double a;
            a = integsqrt(1, -1);
            Console.WriteLine("Значение интеграла: " + a);
        }
    }
}
