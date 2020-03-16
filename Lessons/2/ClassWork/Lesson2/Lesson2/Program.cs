using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your mame ");
            string name = Console.ReadLine();
            string stringOnse = "Helloy";
            string stringTwo = "Two";
            char a = 'a';
            char b = '\u1234';
            Console.WriteLine(b);
            float x = 3.5F;
            double x1= 10.10;
            
            int number = 5/3;
            double number2 = 5.0 / 3;
            Console.WriteLine($"{number} \n{number2}");
            decimal d1 = 10;
            decimal d2 = 10.454545M;
            Console.WriteLine($"{d1}\n{d2}");
            Console.WriteLine(float.MaxValue + 10);
            Console.WriteLine(10.2 / 0.0);
            Console.WriteLine(0.0 / 0.0);

            int i1 = 1;
            short s1 = 1;
            float f1 = 1.0F;
            decimal d3 = 1.3m;
            Console.WriteLine($"{i1}\n{s1}\n{f1}\n{d3}");

            Console.WriteLine("Enter dicimal");
            decimal d4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Decimal {d4}\n");
            Console.WriteLine(Math.Pow(2, -7));

            bool b2 = true;
            bool b3 = false;

            Console.WriteLine(b2 == b3);
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine("aq" == "aq");
            Console.WriteLine("as" != "sd");




            Console.ReadKey();
        }
    }
}
