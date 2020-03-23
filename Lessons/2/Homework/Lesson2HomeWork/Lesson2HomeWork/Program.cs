using System;

namespace Lesson2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Калькулятор, для закрытие программы введите q! \n");
                Console.WriteLine("Ведите первое число: ");
                var firstNumber = Console.ReadLine();
                if (firstNumber == "q!")
                {
                    break;
                }
                Console.WriteLine("Ведите второе число: ");
                var secondNumber = Console.ReadLine();
                Console.WriteLine("Ведите один из шести типов операций\nсложение\nвычитание\nумножение\nделение\nостаток от деления\nвозведение в степень\nЗнак: ");
                var operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {int.Parse(firstNumber) + int.Parse(secondNumber)}");
                        break;
                    case "-":
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {int.Parse(firstNumber) - int.Parse(secondNumber)}");
                        break;
                    case "*":
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {int.Parse(firstNumber) * int.Parse(secondNumber)}");
                        break;
                    case "/":
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {double.Parse(firstNumber) / double.Parse(secondNumber)}");
                        break;
                    case "%":
                        Console.WriteLine($"{firstNumber} % {secondNumber} = {double.Parse(firstNumber) % double.Parse(secondNumber)}");
                        break;
                    case "^":
                        Console.WriteLine($"{firstNumber} ^ {secondNumber} = {Math.Pow(int.Parse(firstNumber), int.Parse(secondNumber))}");
                        break;
                    default:
                        Console.WriteLine("Вы вели что то не то!");
                        break;
                }


            }
        }
    }
}
