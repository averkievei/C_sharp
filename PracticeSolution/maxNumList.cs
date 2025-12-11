using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    internal class maxNumList
    {
        public static void Run()
        {
            //### 1.3. Поиск максимального числа в массиве
            //###Задача:
            //###-Пользователь вводит 5 (или 10) чисел.
            //###-Программа выводит максимальное из них.

            Console.WriteLine("Заполните массив");
            List<int> numArr = new List<int>();

            while (true)
            {
                var userNumber = Console.ReadLine();
                if (userNumber != "")
                {
                    if (!int.TryParse(userNumber, out int number))
                    {
                        Console.WriteLine("Введите именно число");
                        continue;
                    }
                    else
                    {
                        numArr.Add(number);
                    }
                }
                else { break; }
            }
            Console.Write("Максимальный элемент в массиве: " + numArr.Max());
        }
    }
}
