using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace integral
{
    class Program
    {
        static double integsqrt(double a, double b)
        {
            double s1, s2;
            s1 = (a / 2) * Math.Sqrt(a * a + 1) + 0.5 * Math.Log(a + Math.Sqrt(a * a + 1));
            s2 = (b / 2) * Math.Sqrt(b * b + 1) + 0.5 * Math.Log(b + Math.Sqrt(b * b + 1));
            return s1 - s2;
        }
        static double sortirovka(double[] a, double n)
        {
            double k;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        k = a[j];
                        a[j] = a[i];
                        a[i] = k;
                    }
            return 0;
        }
        static void reverse(int[] w, int l)
        {
            int t;
            for (int i = 0; i < l / 2; i++)
            {
                t = w[i];
                w[i] = w[l - i - 1];
                w[l - i - 1] = t;
            }
        }
        static void Main(string[] args)
        {
            //Первое задание - расчет интеграла
            double a;
            a = integsqrt(1, -1);
            Console.WriteLine("Значение интеграла: " + a);
            Console.Write("\n");
            //Второе задание - сортировка массива
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            double[] a1 = new double[n];
            for (int i = 0; i < n; i++)
            {
                a1[i] = Convert.ToDouble(Console.ReadLine());
            }
            sortirovka(a1, n);
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a1[i] + " ");
            }
            // третье задание записать массив задом наперед
            Console.WriteLine("\n");
            int l;
            Console.Write("Введите количество элементов массива: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            int[] w = new int[l];
            for (int i = 0; i < l; i++)
                w[i] = Convert.ToInt32(Console.ReadLine());
            reverse(w, l);
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < l; i++)
                Console.Write(w[i] + " ");

        }



    }
}
    

