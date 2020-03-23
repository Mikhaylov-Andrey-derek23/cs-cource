using System;

namespace ClassWork4
{
    enum Color : int
    {
        Black,
        Blue,
        Cyan,
        Grey,
        Green,
        Magneta,
        Red,
        White,
        Yellow
    }
    class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("Ведите высоту : ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите длину : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь бокавая: {3*h*a}\n");
            double H = Math.Sqrt(h * h - (a * a) / 12.0);
            Console.WriteLine($"Площадь полная: {(3.0/2*a)*(a*Math.Sqrt(3) + 2*h)}\n");
            Console.WriteLine($"Объем: {((a*a)/2.0)*(H*Math.Sqrt(3))}\n");

            Console.WriteLine("Введите код цвет");
            var color = Enum.Parse(typeof(Color) ,Console.ReadLine());
            Console.WriteLine(color);
              

            Console.ReadKey();

        }
    }
}
