using System;
using System.Collections.Generic;

namespace Courses_manger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachersList = new List<Teacher>();
            List<Student> studentsList = new List<Student>();
            List<Course> coursesList = new List<Course>();


        MainPage:
            Console.WriteLine("1- Add teacher \n2- Add student \n3- Add course \n4- Assign course for teacher \n5- Assign course for student \n6- Get teacher's courses \n7- Get student's courses");
            int choiceNumber = int.Parse(Console.ReadLine());
            if (choiceNumber == 1)
            {
                // Add teacher
                Console.WriteLine("Add teacher: ");
                string name = Console.ReadLine();
                Teacher teacher = new Teacher();
                teacher.Name = name;
                teachersList.Add(teacher);

                foreach (Teacher t in teachersList)
                {
                    Console.WriteLine("Mr: " + t.Name);
                }

                Console.WriteLine("Total teachers= " + teachersList.Count);

                goto MainPage;
            }
            else if (choiceNumber == 2)
            {
                Console.WriteLine("Add Student:");
                string studentName = Console.ReadLine();
                Console.WriteLine("What is the grade");
                int grade = int.Parse(Console.ReadLine());
            }
            else if (choiceNumber == 3)
            {
                if (teachersList.Count > 0)
                {
                    Console.WriteLine("Add Course:");
                    string courseName = Console.ReadLine();
                    Console.WriteLine("What is the grade:");
                    int grade = int.Parse(Console.ReadLine());

                    for (int i = 0; i < teachersList.Count; i++)
                    {
                        Console.WriteLine(i + "-" + teachersList[i].Name);
                    }
                    int teacherNumber = int.Parse(Console.ReadLine());
                    Course course = new Course();
                    course.Name = courseName;
                    course.Grade = grade;
                    coursesList.Add(course);
                    teachersList[teacherNumber].Courses.Add(course);
                    goto MainPage;
                }
                else
                {
                    Console.WriteLine("Please add teacher first");
                }
            }
        }
    }
}
