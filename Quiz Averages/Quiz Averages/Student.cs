using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Quiz_Averages
{
    class Student
    {
        public String studentFirstName { get; set; }
        public String studentLastName { get; set; }
        public Collection<double> studentQuizGrades { get; set; }
        public double studentAverage { get; set; }
        public StringBuilder listOfGrades { get; set; }
        public String letterGrade { get; set; }

        public Student()
        {
        }

        public Student(String firstName, String lastName)
        {
            studentFirstName = firstName;
            studentLastName = lastName;
            listOfGrades = new StringBuilder();
            studentQuizGrades = new Collection<double>();
        }

        public Student(String firstName, String lastName, params double[] scores)
        {
            studentFirstName = firstName;
            studentLastName = lastName;
            listOfGrades = new StringBuilder();
            studentQuizGrades = new Collection<double>();

            foreach (double score in scores)
                studentQuizGrades.Add(score);
        }

        public void getQuizScores(String scores)
        {
            if (scores == String.Empty)
                return;

            String[] scoreList = scores.Split(' ');

            foreach (String score in scoreList)
            {
                double dblScore = -1.1;
                if(Double.TryParse(score, out dblScore))
                studentQuizGrades.Add(dblScore);
            }

            calculateAverages();
            calculateLetterGrade();
            studentGradesList();
        }

        public void studentGradesList()
        {
            if (studentQuizGrades == null || studentQuizGrades.Count == 0)
            {
                Console.WriteLine("There are no quiz grades for this student at this time.");
                return;
            }
            listOfGrades.AppendLine("--------------------------------------");
            listOfGrades.AppendLine(String.Format("Student: {0},{1}", studentLastName, studentFirstName));
            listOfGrades.AppendLine(String.Format("# Quizzes: {0}", studentQuizGrades.Count()));

            int count = 1;

            foreach (double score in studentQuizGrades)
            {
                listOfGrades.AppendLine(String.Format("Quiz {0}: {1}", count, score));
                count++;
            }

            listOfGrades.AppendLine(String.Format("Average Grade: {0:f2}", studentAverage));
            listOfGrades.AppendLine(String.Format("Grade: {0}", letterGrade));
            listOfGrades.AppendLine("--------------------------------------");
        }

        public void calculateAverages()
        {
            if (studentQuizGrades == null || studentQuizGrades.Count == 0)
            {
                Console.WriteLine("There are no quiz grades for this student at this time.");
                return;
            }

            double total = 0.0;
            
            foreach (double score in studentQuizGrades)
            {
                total += score;
            }

            studentAverage = total / studentQuizGrades.Count;
        }

        public void calculateLetterGrade()
        {
            if (studentAverage >= 90)
                letterGrade = "A";
            else if (studentAverage >= 80)
                letterGrade = "B";
            else if (studentAverage >= 70)
                letterGrade = "C";
            else if (studentAverage >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";
        }

    }
}
