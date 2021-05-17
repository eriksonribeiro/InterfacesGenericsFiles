using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProposedExercise.Entities
{
    static class TotalStudent
    {
        public static void CountStudent()
        {
            HashSet<Student> studentCourse = new HashSet<Student>();
            string[] course = {"A","B","C"};

            for (int i = 0; i < course.Length; i++)
            {
                Console.Write($"How many students for Course {course[i]}: ");
                int qtd = int.Parse(Console.ReadLine());

                for (int j = 0; j < qtd; j++)
                {
                    Console.Write($"Fill the student ID: ");
                    int id = int.Parse(Console.ReadLine());
                    studentCourse.Add(new Student(id, course[i]));

                }
                Console.WriteLine("");
            }

            Console.WriteLine($"Total students: {studentCourse.Count()}");


        }
    }
}
