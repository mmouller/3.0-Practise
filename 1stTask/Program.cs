using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите целое число: ");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Данное числое чётное");
            }
            else
            {
                Console.WriteLine("\nДанное число нечётное");
            }
        }
    }
}
