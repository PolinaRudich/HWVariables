using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables.Branching_structure
{
    class BranchingSructure2
    {
        static void BranchingSructureTwo(string[]args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число А");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = Convert.ToDouble(Console.ReadLine());

            double result;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите число X");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y");
            double Y = Convert.ToDouble(Console.ReadLine());
            string result;
            if (X > 0&&Y>0)
            {
                result = "I";
                    
            
            }
            else if (X<0&&Y>0)
            {
                result = "II";
            }
            else if (X < 0 && Y < 0)
            {
                result = "III";
            }
            else  
            {
                result = "IV";
            }
            Console.WriteLine(result);

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A < B && B < C)
            {
                Console.WriteLine($"{A},{ B},{ C}");
            }
            else if (B < A && A < C)
            {
                Console.WriteLine($"{B},{A},{C}");
            }
            else if (C < A && A < B)
            {
                Console.WriteLine($"{C},{A},{B}");
            }
            else if (A < C && C < B)
            {
                Console.WriteLine($"{A},{C},{B}");
            }
            else if (B < C && C < A)
            {
                Console.WriteLine($"{B},{C},{A}");
            }
            else if (C < B && B < A)
            {
                Console.WriteLine($"{C},{B},{A}");
            }
        }
    }
}
