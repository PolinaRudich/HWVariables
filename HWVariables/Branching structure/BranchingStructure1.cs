using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWVariables.Branching_structure
{
    class BranchingStructure1
    {
        static void BranchingStructureOne(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число А");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = Convert.ToDouble(Console.ReadLine());

            double result;
            if (A>B)
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

        }

    }
}
