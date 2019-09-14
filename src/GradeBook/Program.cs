using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ryan's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.AddGrade(100);
            book.AddGrade(165);
            //book.grades.Add(101); // bad to give direct access to field without going through method
            var stats = book.GetStatistics();

            Console.WriteLine($"Statistics for book:");
            Console.WriteLine($"The lowest grade  is {stats.Low:N1}");
            Console.WriteLine($"The highest grade  is {stats.High:N1}");
            Console.WriteLine($"The average grade  is {stats.Average:N2}\n");

            
        } 
    }

}
