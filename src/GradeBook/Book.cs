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

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var total = 0.00;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                total += grade;
            }
            result.Average = total;
            result.Average /= grades.Count;
            return result;
        }


        private List<double> grades;
        private string name;
        
    }
}