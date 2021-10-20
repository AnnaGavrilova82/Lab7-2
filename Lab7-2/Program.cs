using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размеры сторон первого треугольника a1, b1, c1 = ");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            double c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размеры сторон второго треугольника a2, b2, c2 = ");
            double a2 = Convert.ToInt32(Console.ReadLine());
            double b2 = Convert.ToInt32(Console.ReadLine());
            double c2 = Convert.ToInt32(Console.ReadLine());

            double t1 = CalcPloshad(a1, b1, c1);
            double t2 = CalcPloshad(a2, b2, c2);
            Console.WriteLine("Площадь первого треугольника {0}", t1);
            Console.WriteLine("Площадь второго треугольника {0}", t2);
            if(t1>t2)
            Console.WriteLine("Площадь первого треугольника больше");
            else
            Console.WriteLine("Площадь второго треугольника больше");

            Console.ReadKey();
        }
        static double CalcPloshad(double a, double b, double c)

        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p-a) * (p - b) * (p - c));
            return S;
            //Console.ReadKey();

        }
    }
}
