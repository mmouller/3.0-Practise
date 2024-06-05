using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            Console.WriteLine("\nВведите число: ");
            int userNumber = int.Parse(Console.ReadLine());
            int i = 2;
            while (i <= userNumber - 1)
            {
                if (userNumber % i == 0)
                {
                    condition = false;
                    break;
                }
                i++;
            }
            if (condition)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();
        }
    }
}
