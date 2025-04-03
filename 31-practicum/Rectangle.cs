using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    class Rectangle: Figure
    {
        private double side1;
        private double side2;

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
                    throw new Exception("значене не должно быть быть отрицательным или равно 0");
                }
                else
                {
                    side2 = value;
                }
            }
        }
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            Name = "прямоугольник";
            Side1 = side1;
            Side2 = side2;
        }
        public override double Area()
        {
            return Side1 * Side2;
        }
        public override double Perimeter()
        {
            return 2*(Side1 + Side2);
        }
       public static Figure NewFigure()
       {
            Console.Clear();
            Console.Write("Введите длину первой стороны: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите длину вторйо стороны: ");
            double side2 = double.Parse(Console.ReadLine());
            return new Rectangle("прямоугольник", side1, side2);
       } 
        public override string Print()
        {
            return $"Первая сторона прямоугольника = {Side1}, вторая сторона = {Side2}, периметр = {Perimeter()}, площадь = {Area()}";
        }
    }
}
