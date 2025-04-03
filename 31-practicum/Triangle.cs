using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    class Triangle: Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("значение не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    side1 = value;
                }
            }
        }
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("значение не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    side2 = value;
                }
            }
        }
        public double Side3
        {
            get
            {
                return side3;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("значение не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    side3 = value;
                }
            }
        }
        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            Name = "треугольник";
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public bool IsTriangleExist()
        {
            if (side1 <= side2 + side3 || side2 <= side1 + side3 || side3 <= side2 + side1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsTriangleExist(double side1, double side2, double side3)
        {
            if (side1 <= side2 + side3 || side2 <= side1 + side3 || side3 <= side2 + side1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override double Area()
        {
            if (IsTriangleExist())
            {
                double p = Perimeter() / 2;
                return Math.Sqrt(p*(p-Side1)*(p-Side2)*(p-Side3));
            }
            else
            {
                Console.WriteLine(Print());
                return 0;
            }
        }

        public override double Perimeter()
        {
            if (IsTriangleExist())
            {
                return Side1 + Side2 + Side3;
            }
            else
            {
                Console.WriteLine(Print());
                return 0;
            }
        }
        public static Figure NewFigure()
        {
            Console.Clear();
            Console.Write("Введите длину первой стороны: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите длину второй стороны: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Введите длину третьей стороны: ");
            double side3 = double.Parse(Console.ReadLine());
            if (IsTriangleExist(side1, side2, side3))
            {
                return new Triangle("треугольник", side1, side2, side3);
            }
            else
            {
                Console.WriteLine("Треугольника не существует");
                return new Triangle("треугольник",0,0,0);
            }
            
        }
        public override string Print()
        {
            if (!IsTriangleExist())
                return $"Первая сторона треугольника = {Side1}, вторая сторона = {Side2}, третья сторона = {Side3}, периметр = {Perimeter()}, площадь = {Area()}";
            else
                return "Треугольника не существует";
        }
    }
}
