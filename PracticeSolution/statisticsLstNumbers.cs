using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    internal class statisticsLstNumbers
    {
        public static void Run() {
            //### 1. Диапазон и статистика массива
            //Задача:
            //Пользователь вводит N чисел(разрешить ввод только целых, массив динамический — `List<int>`).  
            //Требуется:
            //-Найти и вывести:
            //-минимальное и максимальное число,
            //-сумму,
            //-среднее арифметическое,
            //-количество чётных и нечётных чисел.

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
            if (numArr.Count == 0)
            {
                Console.WriteLine("Массив пуст!");
                return;
            }

            Console.Write("Максимальный элемент в массиве: " + numArr.Max() + "\n");
            Console.Write("Минимальный элемент в массиве: " + numArr.Min() + "\n");
            Console.Write("Сумма: " + numArr.Sum() + "\n");
            Console.Write("Среднее: " + numArr.Average() + "\n");
            int countEven = 0;
            int countOdd = 0;
            foreach (var item in numArr)
            {
                if ((item % 2 == 0))
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.Write("Четных элементов в массиве: " + countEven + "\n");
            Console.Write("Нечетных элементов в массиве: " + countOdd + "\n");
        }
    }
}
