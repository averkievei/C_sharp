using PracticeSolution;
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1 - Сложение двух чисел");
        Console.WriteLine("2 - Угадай число");
        // ... и т.д.

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                sumNumbers.Run();
                break;
            case "2":
                searchNumber.Run();
                break;
            // ...
            default:
                Console.WriteLine("Неверный выбор");
                break;
        }
    }
}