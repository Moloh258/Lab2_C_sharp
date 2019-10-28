using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, dlina, shirina;
            Console.WriteLine("Введите координаты точек");
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            dlina = Math.Abs(x2 - x1);
            shirina = Math.Abs(y2 - y1);
            x1 = dlina * shirina;
            x2 = 2 * (dlina + shirina);
            Console.WriteLine("Площадь прямоугольника равна {0}", x1);
            Console.WriteLine("Периметр равен {0}", x2);
        }
    }
}
