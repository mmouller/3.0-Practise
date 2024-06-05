using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
