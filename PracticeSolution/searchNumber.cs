using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    internal class searchNumber
    {
        public static void Run()
        {
            //### 1.2. Угадай число
            //###Задача:
            //###Компьютер загадывает случайное число от 1 до 100, пользователь угадывает число, программа подсказывает “меньше” или “больше” до победы.

            while (true)
            {
                var rand = new Random();
                var randN = rand.Next(0, 11);
                Console.WriteLine("Угадай число загаданное компьютером, путем ввода числа с клавиатуры от 0 до 10");

                var game = true;
                while (game)
                {
                    var userNumber = Console.ReadLine();

                    if (!int.TryParse(userNumber, out int number))
                    {
                        Console.WriteLine("Введите именно число");
                        continue;
                    }
                    else if (number < randN)
                    {
                        Console.WriteLine("Ваше число меньше \nПопробуйте еще раз");

                        continue;
                    }
                    else if (number > randN)
                    {
                        Console.WriteLine("Ваше число больше \nПопробуйте еще раз");

                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ура!!! Вы угадали чсло\nЕсли хотите начать заново введите с клавиатуры 'ДА', если хотите выйти введите 'НЕТ'");
                        while (true)
                        {
                            string userSrt = Console.ReadLine();

                            if (userSrt.ToUpper() == "ДА")
                            {
                                Console.Clear();
                                break;
                            }
                            else if (userSrt.ToUpper() == "НЕТ")
                            {
                                game = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод");
                                continue;
                            }
                        }
                        break;
                    }

                }

                if (!game)
                {
                    break;
                }
            }
        }
        }
}
