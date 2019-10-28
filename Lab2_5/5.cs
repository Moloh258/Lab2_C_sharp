using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a1, a2, b1, b2, c1, c2, ab, bc, ca, p, p_2, s;

            Console.WriteLine("Обозначьте координаты первой вершины (a1;a2)");
            a1 = Convert.ToDouble(Console.ReadLine());
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Обозначьте координаты второй вершины (b1;b2)");
            b1 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Обозначьте координаты третьей вершины (с1;с2)");
            c1 = Convert.ToDouble(Console.ReadLine());
            c2 = Convert.ToDouble(Console.ReadLine());

           
            ab = (Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2)));
            bc = (Math.Sqrt(Math.Pow(c1 - b1, 2) + Math.Pow(c2 - b2, 2)));
            ca = (Math.Sqrt(Math.Pow(a1 - c1, 2) + Math.Pow(c2 - a2, 2)));
            p = ab + bc + ca;
            p_2 = p / 2; 
            s = Math.Sqrt(p_2 * ((p_2 - ab) * (p_2 - bc) * (p - ca)));
            Console.WriteLine(string.Format("p = {0:N2}, s = {1}", p, s));

            Console.ReadLine();
        }
    }
}
