using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \"Угадай - ка\"");
            Console.WriteLine("Пожалуйста, введите максимальное целое число: ");
            int secretNumber = new Random().Next(Convert.ToInt32(Console.ReadLine()));


            while (true)
            {
                Console.WriteLine("Попробуйте угадать число: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine($"Было загадано число {secretNumber}");
                    break;
                }

                int userNumber = Convert.ToInt32(userInput);

                if (userNumber < secretNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного, попробуйте еще!");
                }
                else if (userNumber > secretNumber)
                {
                    Console.WriteLine("Ваше число больше загаданного, попробуйте еще!");
                }
                else
                {
                    Console.WriteLine("Вы угадали, поздравляю!");
                }
            }
            Console.ReadKey();
        }
    }
}
