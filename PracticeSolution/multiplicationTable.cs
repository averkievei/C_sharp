using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution
{
    internal class multiplicationTable
    {
        public static void Run() {
            //### 1.4. Таблица умножения
            //Задача:
            //Сгенерировать и вывести в консоль таблицу умножения для чисел от 1 до 10.
            string[,] arrFull_1 = new string[9, 4];
            string[,] arrFull_2 = new string[9, 4];
            //вывод разделен 
            for (int i1 = 0; i1 < arrFull_1.GetLength(0); i1++)
            {

                for (int j1 = 0; j1 < arrFull_1.GetLength(1); j1++)
                {
                    arrFull_1[i1, j1] = j1 + 2 + " * " + (i1 + 1) + " = " + ((i1 + 1) * (j1 + 2));
                    Console.Write($"{arrFull_1[i1, j1]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i2 = 0; i2 < arrFull_2.GetLength(0); i2++)
            {

                for (int j2 = 0; j2 < arrFull_2.GetLength(1); j2++)
                {
                    arrFull_2[i2, j2] = j2 + 6 + " * " + (i2 + 1) + " = " + ((i2 + 1) * (j2 + 6));
                    Console.Write($"{arrFull_2[i2, j2]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //вывод без разделения
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write($"{j} * {i} = {j * i,2}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
