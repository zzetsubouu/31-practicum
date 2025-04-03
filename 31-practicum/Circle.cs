using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    class Circle: Figure
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("значение не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle(string name, double radius) : base(name)
        {
            Name = "круг";
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public static Figure NewFigure()
        {
            Console.Clear();
            Console.Write("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());
            return new Circle("круг",r);
        }
        public override string Print()
        {
            return $"Радиус круга равен{Radius}, периметр = {Perimeter()}, площадь = {Area()}";
        }
    }
}
