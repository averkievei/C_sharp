using PracticeSolution;
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("ЭТАП 1.Основы синтаксиса и простые задачи");        
        Console.WriteLine(" 1.1 - Сложение двух чисел");
        Console.WriteLine(" 1.2 - Угадай число");
        Console.WriteLine(" 1.3 - Поиск максимального числа в массиве");
        Console.WriteLine(" 1.4 - Таблица умножения");
        Console.WriteLine(" 1.5 - Диапазон и статистика массива");



        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1.1":
                sumNumbers.Run();
                break;
            case "1.2":
                searchNumber.Run();
                break;
            case "1.3":
                maxNumList.Run();
                break;
            case "14":
                multiplicationTable.Run();
                break;
            case "1.5":
                statisticsLstNumbers.Run();
                break;
                
            // ...
            default:
                Console.WriteLine("Неверный выбор");
                break;
        }
    }
}