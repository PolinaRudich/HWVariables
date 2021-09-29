using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables
{
    class Variables1
    {
        static void VariablesOne(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число A");
            double valueA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double valueB = Convert.ToDouble(Console.ReadLine());
            double result = (5 * valueA + Math.Pow(valueB, 2)) / (valueB - valueA);
            Console.WriteLine($"результат: {result}");
            Console.WriteLine();
        }
    }
}
