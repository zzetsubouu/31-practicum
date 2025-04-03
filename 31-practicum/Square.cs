using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    class Square: Figure
    {
        private double side1;
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
                    throw new Exception("значене не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    side1 = value;
                }
            }
        }
        public Square(string name, double side1) : base(name)
        {
            Name = "квадрат";
            Side1 = side1;
        }
        public override double Area()
        {
            return Side1 * Side1;
        }
        public override double Perimeter()
        {
            return Side1*4;
        }
        public static Figure NewFigure()
        {
            Console.Clear();
            Console.Write("Введите длину стороны квадрата: ");
            double side = double.Parse(Console.ReadLine());
            return new Square("Квадрат", side);
        }
        public override string Print()
        {
            return $"Стороны квадрата равны {Side1}, периметр = {Perimeter()}, площадь = {Area()}";
        }
    }
}
