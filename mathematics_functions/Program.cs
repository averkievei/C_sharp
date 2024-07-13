using  System;

namespace matematics_functions {
    class Program {
        static void Main() {
            // Console.Write("Введите число с точкой: ");
            // //user_input = Convert.ToDouble(Console.ReadLine());
            // float user_input = float.Parse(Console.ReadLine());

            // float result;
            // result = user_input + 10f;

            // // result = user_input - 15f;
            // // result = user_input * 2f;
            // // result = user_input / 5f;
            // // result = user_input % 2f; // остаток при делении 

            // // сокращенный вариант
            // // result += 1f;
            // // result ++;
            // // result -= 1f;
            // // result --;
            // // result /= 2f;
            // // result *= 2f;

            // Console.WriteLine("Переменная: " + result);
            //константы:
            System.Console.WriteLine(Math.PI);

            //округления:
            System.Console.WriteLine(Math.Ceiling(14.1));//округление к большему
            System.Console.WriteLine(Math.Floor(14.1));//округление к меньше22му
            System.Console.WriteLine(Math.Round(14.51));//округление к меньшему либо к меньшему 0.5

            //стандартные математические функции:
            System.Console.WriteLine(Math.Min(0,5));
            System.Console.WriteLine(Math.Max(0,5));
            System.Console.WriteLine(Math.Pow(5,2)); //возведение в степень

            //пример:
            Console.WriteLine("введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);

        }
    }
}