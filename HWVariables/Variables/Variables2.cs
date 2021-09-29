using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables
{
    class Variables2
    {
        static void VariablesSecond(string []args)
        {
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
        }
    }
}
