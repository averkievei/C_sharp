using  System;

namespace if_else {
    class Program {
        static void Main() {
            System.Console.Write("Enter name: ");
            string? role = System.Console.ReadLine();
            if(role == "Admin") {
                Console.Write("Enter user name: ");
                string? user_name = System.Console.ReadLine();
                System.Console.Write("Enter {0} age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine());

                if(age <= 0 || age > 99) {
                    Console.WriteLine("Error");
                    age = 0;
                } else {
                    Console.WriteLine("User's age is " + age);
                }   
            } else {
                Console.WriteLine("You are not admin!");
            }
        }
    }
}