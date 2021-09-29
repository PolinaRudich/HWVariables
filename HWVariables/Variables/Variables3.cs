using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables
{
    class Variables3
    {
        static void VariablesThree(string[]args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result1 = number1 / number2;
            int result2 = number1 % number2;
            Console.WriteLine($"{result1}, {result2}");
            Console.WriteLine();
        }
    }
}
