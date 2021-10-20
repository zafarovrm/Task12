using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {        
        static void Main(string[] args)
        {
            double radius,x,y,x0,y0 = 0;
            Console.WriteLine("Введите значение R:");
            try
            {
                radius = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("C={0}", Circle.GetLength(radius)); 
            Console.WriteLine("S={0}", Circle.GetArea(radius));            
            Console.WriteLine("Введите значение x0:");
            try
            {
                x0 = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите значение y0:");
            try
            {
                y0 = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите значение x:");
            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите значение y:");
            try
            {
                y = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Circle.Point centerCircle = new Circle.Point(x0,y0);            
            Circle.Point point = new Circle.Point(x, y);
            Console.WriteLine("Принадлежность окружности: {0}", Circle.Point.CheckPoint(centerCircle, radius, point));
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double GetLength(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }                
        public class Point
        {
            double x, y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public static bool CheckPoint(Point center, double radius, Point point)
            {
                return (Math.Sqrt(Math.Pow(point.x - center.x, 2.0) + Math.Pow(point.y - center.y, 2.0)) <= radius);
            }
        }
    }
}   