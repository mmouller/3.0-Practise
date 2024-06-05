using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в последовательности : ");
            int numbersInSequence = Int32.Parse(Console.ReadLine()), min = int.MaxValue, val = -1;
            for (; numbersInSequence > 0; numbersInSequence--)
            {
                val = Int32.Parse(Console.ReadLine());
                min = min > val ? val : min;
            }
            Console.WriteLine("min : " + min);
            Console.ReadKey(true);
        }
    }
}
