using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Modul3.Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-еЗадание.
            /*            
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

            */

            #endregion

            #region 2-еЗадание.
            /*
            do
            {
            Console.WriteLine("\nПриветствую Вас, игрок!. Ваша задача набрать 21 очко посредством карт. \nСколько карт у Вас на руках?");
            int userCards = int.Parse(Console.ReadLine());
            int sum = 0;
                for (int i = 1; i <= userCards; i++)
                {
                    Console.Write("\nВведите номинал карты:\n");
                    string handValue = Console.ReadLine();

                    switch (handValue)
                    {
                        case "2": sum += 2; break;
                        case "3": sum += 3; break;
                        case "4": sum += 4; break;
                        case "5": sum += 5; break;
                        case "6": sum += 6; break;
                        case "7": sum += 7; break;
                        case "8": sum += 8; break;
                        case "9": sum += 9; break;
                        case "10": case "J": case "Q": case "K": case "T": sum += 10; break;
                        default: Console.WriteLine("Допустимы номиналы от 2 до 10, \nа также J - Валет, Q - Дама, K - Король, T - Туз"); i--; break;
                    }
                }
                Console.WriteLine("Сумма карт на руке:" + sum);

                if (sum > 21)
                {
                    Console.WriteLine("К сожалению у Вас перебор! Вы проиграли :(");
                }
                else if (sum < 21)
                {
                    Console.WriteLine("Ай ай, не хватило. Попробуйте еще раз!");
                }
                else
                {
                    Console.WriteLine(" Ура, у Вас получилось! Вы молодец! :)");
                }
                Console.WriteLine("Хотите попробовать еще раз? \nНажмите клавишу \"Y\" чтобы начать сначала, нажмите клавишу \"N\", чтобы закрыть игру");

            } while (Console.ReadLine() != "N");
            */
            #endregion

            #region 3-еЗадание.
            /*          
            bool condition = true;
            Console.WriteLine("\nВведите число: ");
            int userNumber = int.Parse(Console.ReadLine());
            int i = 2;
            while (i <= userNumber - 1)
            {
                if(userNumber % i == 0)
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
*/
            #endregion

            #region 4-еЗадание.
            /* 
            Console.Write("Введите количество чисел в последовательности : ");
            int numbersInSequence = Int32.Parse(Console.ReadLine()), min = int.MaxValue, val = -1;
            for (; numbersInSequence > 0; numbersInSequence--)
            {
                val = Int32.Parse(Console.ReadLine());
                min = min > val ? val : min;
            }
            Console.WriteLine("min : " + min);
            Console.ReadKey(true);
            */
            #endregion

            Console.WriteLine("Игра \"Угадай - ка\"");
            Console.WriteLine("Пожалуйста, введите максимальное целое число: ");
            int maxUserNumber = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int iiNumber = rand.Next(1, maxUserNumber);
            int count = 0;
            int userNumber;

            do
            {

                Console.Write("\nВведите число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз");
                }
                else
                {
                    Console.WriteLine($"Поздравляю, число угадано! Число попыток: {count}."); ;
                }
                
            } while (Console.ReadLine() != string.Empty);

            


        }


    }
}
