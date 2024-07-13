using  System;

namespace switch_case {
    class Program {
        static void Main() {
            System.Console.Write("Enter number: ");
            short user_input = Convert.ToInt16(Console.ReadLine());

            switch(user_input) {
                case 5:
                    System.Console.Write("number is " + user_input);
                    break;
                case 15:
                    System.Console.Write("number is " + user_input);
                    break;
                case 20:
                    System.Console.Write("number is " + user_input);
                    break;
                case 50:
                    System.Console.Write("number is " + user_input);
                    break;
                default:
                    System.Console.Write("number is not unrecognized");
                    break;
            }
        }
    }
}