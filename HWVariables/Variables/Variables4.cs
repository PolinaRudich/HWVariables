using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables
{
    class Variables4
    {
        static void VariablesFour(string[]args)
        {
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
        }
    }
}
