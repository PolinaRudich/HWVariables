using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables
{
    class Variables5
    {
        static void VariablesFive(string[] args)
        {
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
