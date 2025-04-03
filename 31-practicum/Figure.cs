using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    abstract class Figure
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Figure(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        //public abstract Figure NewFigure(); неправильно, в производных оно должно быть сттическим
        public virtual string Print()
        {
            return $"Название фигуры: {Name}";
        }
        public static void DisplayAll(IEnumerable<Figure> figures)
        {
            Console.Clear();
            Console.WriteLine("Все фигуры:");
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Print());
            }
        }
    }
}
