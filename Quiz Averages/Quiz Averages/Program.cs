using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Quiz_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<Student> students = new Collection<Student>();

            do
            {
                Student newStudent = new Student(ReadPrompt("Enter your student's first name."), ReadPrompt("Enter your student's last name"));
                if (newStudent.studentFirstName.ToUpper() != "EXIT")
                {
                    newStudent.getQuizScores(ReadPrompt("Enter your student's scores\nseparated by a single space for each score"));
                }
                students.Add(newStudent);
            } while (students[students.Count - 1].studentFirstName.ToUpper() != "EXIT");

            foreach (Student s in students)
            Console.WriteLine(s.listOfGrades);
        }
        
        public static String ReadPrompt(String consoleText)
        {
            Console.Write(consoleText + "-->");
            return Console.ReadLine();
        }
    }
}
