using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добавить в производных классах Figure (Circle, Rectangle и т.д.) статический метод для ввода данных об объекте
            List<Figure> figures = new List<Figure>();
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите название фигуры (r, c, s или t , l для выхода, d чтобы вывести все элементы коллекции): ");
                string mark = Console.ReadLine();
                switch (mark.ToLower())
                {
                    case "r":
                        {
                            figures.Add(Rectangle.NewFigure()); break;
                        }
                    case "c":
                        {
                            figures.Add(Circle.NewFigure()); break;
                        }
                    case "s":
                        {
                            figures.Add(Square.NewFigure()); break;
                        }
                    case "t":
                        {
                            figures.Add(Triangle.NewFigure()); break;
                        }
                    case "l":
                        {
                            Console.WriteLine("Завершение работы...");
                            flag = false;
                            break;
                        }
                    case "d":
                        {
                            Figure.DisplayAll(figures);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Нет такой функции."); break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
