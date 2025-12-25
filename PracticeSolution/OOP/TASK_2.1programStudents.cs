using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
 

namespace PracticeSolution.OOP
{
    internal class programStudents
    {
        public static void Run()
        {
            List<Student> students = new List<Student>();
            while (true)
            {


                Console.WriteLine("Введите имя судента:");
                var inputName = Console.ReadLine();
                if (inputName.Trim().ToUpper() == "EXIT")
                    break;
                while (string.IsNullOrWhiteSpace(inputName))
                {
                    Console.WriteLine("Введите имя студента:");
                    inputName = Console.ReadLine();
                }

                Console.WriteLine("Введите возраст судента:");
                int inutAge;
                while (!int.TryParse(Console.ReadLine(), out inutAge))
                    Console.Write("Ошибка. Повторите ввод возраста: ");

                Console.WriteLine("Введите группу судента:");
                var inputGroup = Console.ReadLine();              
                while (string.IsNullOrWhiteSpace(inputGroup))
                {
                    Console.WriteLine("Введите группу студента:");
                    inputGroup = Console.ReadLine();
                }

                Console.WriteLine("Введите оценки через пробел: ");
                var inputGrades = Console.ReadLine()
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => int.Parse(x))
                                   .ToList();

                students.Add(new Student
                {
                    Name = inputName,
                    Age = inutAge,
                    Group = inputGroup,
                    Grades = inputGrades
                });

                Console.WriteLine("Если желаете добавить еще запись нажмите ENTER для выхода вбейту exit");
            }

            foreach (var student in students) { 
                student.PrintInfo();
                
            }
            //Группировка по группам
            Student.PrintStudentsByGroups(students);

            //Лучший студент в каждой группе
            Student.PrintStudentsByGroupsBest(students);

            Student.SearchAVE(students);
        }
        
    }
}
