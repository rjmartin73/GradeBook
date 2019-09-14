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
            book.ComputeStatistics();

            var book2 = new Book("Bob's Grade Book");
            book2.AddGrade(100);
            book2.AddGrade(63.5);
            book2.AddGrade(45);
            book2.AddGrade(105);
            book2.ComputeStatistics();
            
        } 
    }

}
