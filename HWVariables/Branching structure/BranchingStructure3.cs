using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables.Branching_structure
{
    class BranchingStructure3
    {
        static void BranchingSructureThree(string[] args)
        {
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
             else if (B<A&&A<C)
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
