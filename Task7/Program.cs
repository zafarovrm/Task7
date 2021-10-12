using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1ю сторону 1-го треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2ю сторону 1-го треугольника");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3ю сторону 1-го треугольника");
            int c = Convert.ToInt32(Console.ReadLine());
            double S;
            GetParam(a, b, c, out S);
            double S1 = S;
            Console.WriteLine("Площадь 1го треугольника равна {0}", S1);
            Console.WriteLine();
            Console.WriteLine("Введите 1ю сторону 2-го треугольника");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2ю сторону 2-го треугольника");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3ю сторону 2-го треугольника");
            c = Convert.ToInt32(Console.ReadLine());
            GetParam(a, b, c, out S);
            double S2 = S;
            Console.WriteLine("Площадь 2го треугольника равна {0}", S2);
            Console.WriteLine();
            if (S1 > S2)
            {
                Console.WriteLine("Площадь 1го треугольника больше");
            }
            if (S1 < S2)
            {
                Console.WriteLine("Площадь 2го треугольника больше");
            }
            if (S1 == S2)
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
        static void GetParam(int a, int b, int c, out double S)
        {
            double p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
