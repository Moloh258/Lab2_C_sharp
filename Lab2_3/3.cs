using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, lAC, lBC;

            Console.WriteLine("Введите координаты точки А");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки В");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C");
            C = int.Parse(Console.ReadLine());

            lAC = Math.Abs(A - C);
            lBC = Math.Abs(B - C);

            A = lAC * lBC;

            Console.WriteLine("Произведение длин отрезков AC и BC:{0}", A);

            Console.ReadKey();
        }
    }
}
