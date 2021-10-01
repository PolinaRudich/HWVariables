using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число A");
            double valueA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double valueB = Convert.ToDouble(Console.ReadLine());
            double result = (5 * valueA + Math.Pow(valueB, 2)) / (valueB - valueA);
            Console.WriteLine($"результат: {result}");

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первую строку");
            string stringOne = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string stringTwo = Console.ReadLine();
            string tmpString = stringTwo;
            stringTwo = stringOne;
            stringOne = tmpString;
            Console.WriteLine($"Результат: {stringOne + stringTwo}");
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result1 = number1 / number2;
            int result2 = number1 % number2;
            Console.WriteLine($"{result1}, {result2}");
            Console.WriteLine();

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число , не равное 0");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число, не равное нулю");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число, не равное нулю");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double result4 = num3 - num2 / num1;
            Console.WriteLine($"результат: {result4}");
            Console.WriteLine();

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double A = (y2 - y1) / (x2 - x1);
            Console.WriteLine(A);
            double B = y2 - (A * x2);
            Console.WriteLine($"Y = {A}*X + {B} ");
            Console.WriteLine();

        }
    }
}
