using  System;

namespace iteration {
    class Program {
        static void Main() {
            //цикл for
            // for(float i = 200; i > 10; i /= 2)
            //     Console.WriteLine("Element: {0}", i);

            //цикл while
            // short i = 10;
            // while(i >= 1 ) 
            // {
            //     Console.WriteLine("Element: {0}", i);
            //     i--;
            // }

            // bool isHasCar = true;
            // while (isHasCar)
            // {
            //     string? user_input = Console.ReadLine();
            //     if(user_input == "end")
            //         isHasCar = false;
            // }

            // byte i = 100;
            // do {
            //     Console.WriteLine("Element: " + i);
            // } while(i < 10);

            //оператор break и continue
            for(short i = 0; i < 10; i++) {
                // if(i > 5)
                //     break; //полностью выходим из цикла 
                if(i % 2 == 0)
                    continue; //завершаем одну итерацию из цикла
                Console.WriteLine("El: " + i);
            }
        }
    }
}