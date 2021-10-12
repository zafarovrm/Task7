using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double S,V;
            GetParam(a, out S, out V);            
            Console.WriteLine("Площадь поверхности куба равна {0}", S);
            Console.WriteLine("Обьем куба равен {0}", V);
            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
        static void GetParam(int a, out double S, out double V)
        {
            S = 6 * Math.Pow(a, 2.00);
            V = Math.Pow(a, 3.00);
        }
    }
}
