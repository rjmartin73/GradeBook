using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade < 0 || grade > 110)
            {
                Console.WriteLine($"//////// {grade} was entered into {name} and is not a valid.\n");
                return;
            }
            grades.Add(grade);
        }

        public void ComputeStatistics()
        {
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;
            var averageGrade = 0.00;
            var total = 0.00;

            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                total += grade;
            }
            averageGrade = total;
            averageGrade /= grades.Count;

            Console.WriteLine($"Statistics for {name}:");
            Console.WriteLine($"The lowest grade  is {lowGrade:N1}");
            Console.WriteLine($"The highest grade  is {highGrade:N1}");
            Console.WriteLine($"The average grade  is {averageGrade:N2}\n");
        }


        private List<double> grades;
        private string name;
    }
}