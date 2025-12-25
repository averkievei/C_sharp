using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSolution.OOP
{
    internal class Student
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public List<int> Grades { get; set; }
        public double GetAverageGrade() => Grades.Average();
        public double GetMaxGradeGroup() => Grades.Max();

        public void PrintInfo()
        {
            Console.WriteLine($"{Name}, {Age} лет, Группа: {Group},  ср. балл: {GetAverageGrade():F2}");
        }
        //Группировка студентов по группам
        public static void PrintStudentsByGroups(List<Student> students)
        {
            Console.WriteLine("\nСтуденты по группам:");
            var grouped = students.GroupBy(s => s.Group);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Группа {group.Key}:");
                foreach (var st in group)
                    Console.WriteLine($"  {st.Name} (ср.балл: {st.GetAverageGrade():F2})");
            }
        }
        //Найти студента(ов) с максимальным средним баллом в каждой группе.
        public static void PrintStudentsByGroupsBest(List<Student> students) 
        {
            Console.WriteLine("\nЛучший студент в каждой группе:");
            var grouped = students.GroupBy(s => s.Group);
            foreach (var group in grouped)
            {
                var max = group.Max(s => s.GetAverageGrade());
                var bestStudents = group.Where(s => s.GetAverageGrade() == max);
                Console.WriteLine($"Группа {group.Key}:");
                foreach (var st in bestStudents)
                    Console.WriteLine($"  {st.Name}, ср.балл: {st.GetAverageGrade():F2}");
            }
        }

        //Поиск по среднему баллу

        public static void SearchAVE(List<Student> students)
        {
            Console.WriteLine("Введите возраст судента:");
            double inutAge;
            while (!double.TryParse(Console.ReadLine(), out inutAge))
                Console.Write("Введите средний бал для поиска студентов: ");

            var filter = students.Where(s => s.GetAverageGrade() >= inutAge);
            foreach (var student in filter)
                Console.WriteLine($"{student.Name}, {student.Age} лет, Группа: {student.Group},  ср. балл: {student.GetAverageGrade():F2}");
        }

    }
}
