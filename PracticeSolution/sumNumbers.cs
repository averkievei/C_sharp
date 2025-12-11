

namespace PracticeSolution
{
    internal class sumNumbers
    {
        public static void Run() {
            //### 1.1. Сложить 2 числа, введённых с клавиатуры  
            Console.WriteLine("Введите число 1 ");
            var a1 = Console.ReadLine();

            while (!int.TryParse(a1, out int number))
            {
                Console.Clear();
                Console.WriteLine("Введите именно число");
                a1 = Console.ReadLine();
            }

            Console.WriteLine("Введите число 2 ");
            var a2 = Console.ReadLine();

            while (!int.TryParse(a2, out int number))
            {
                Console.Clear();
                Console.WriteLine("Введите именно число");
                a2 = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Результат сложения двух чисел: " + a1 + " + " + a2 + " = " + (Int32.Parse(a1) + Int32.Parse(a2)));//конвертация string в int32
        }
    }
}
