/*Треугольник задан координатами своих вершин.
 Разработать подпрограмму для вычисления периметра треугольника.*/

using System;

namespace Лаба_1
{
    class Program
    {
        // функция для расчёта длинны стороны
        static double SideOfTriangle(double x1, double y1, double x2, double y2)
        {
           double Side;
           Side = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
           Side = Math.Abs(Side);         // модуль 
           return Side;
        }
        static void Main(string[] args)
        {
            string str;
            double AX, AY, BX, BY, CX, CY; // координаты вершин
            double Perimeter;

            // ввод координат вершин и конвертация их в int

            Console.WriteLine("X вершины А = ");
            str = Console.ReadLine();
            AX = Convert.ToDouble(str);
            Console.WriteLine("Y вершины А = ");
            str = Console.ReadLine();
            AY = Convert.ToDouble(str);

            Console.WriteLine("X вершины B = ");
            str = Console.ReadLine();
            BX = Convert.ToDouble(str);
            Console.WriteLine("Y вершины B = ");
            str = Console.ReadLine();
            BY = Convert.ToDouble(str);

            Console.WriteLine("X вершины C = ");
            str = Console.ReadLine();
            CX = Convert.ToDouble(str);
            Console.WriteLine("Y вершины C = ");
            str = Console.ReadLine();
            CY = Convert.ToDouble(str);

            if (AX != BX & AY != BY)
            {
                if (CX != BX & CY != BY)
                {
                    if (AX != CX & AY != CY)
                    {
                        // подсчёт периметра 

                        Perimeter = SideOfTriangle(AX, AY, BX, BY);
                        Perimeter += SideOfTriangle(BX, BY, CX, CY);
                        Perimeter += SideOfTriangle(CX, CY, AX, AY);

                        // вывод результата в консоль

                        Console.WriteLine("Периметр треугольника = " + Perimeter);
                    }
                    else
                    {
                        Console.WriteLine("Координаты точек не могут совпадать!");

                    }
                }
                else
                {
                    Console.WriteLine("Координаты точек не могут совпадать!");

                }
            }
            else
            {
                Console.WriteLine("Координаты точек не могут совпадать!");

            }
        }
    }
}
