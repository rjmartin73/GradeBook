using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        // [Fact] // attribute makes it a test method
        // public void Test()
        // {   /*
        //         Break tests up into 3 sections 
        //         1. arrange - build or put together test data
        //         2. act - invoke method to produce a result
        //         3. assert - test the value from step 2
        //      */

        //     // arrange section


        // }

        [Fact]
        static void Test1()
        {
            var book1 = new Book("book1");
            book1.AddGrade(89.1);
            book1.AddGrade(90.5);
            book1.AddGrade(77.3);
            book1.AddGrade(99);
            book1.AddGrade(88.975);

            var result1 = book1.GetStatistics();
            Assert.Equal(88.975, result1.Average, 1);
            Assert.Equal(77.3, result1.Low, 1);
            Assert.Equal(99, result1.High, 1);
        }
        [Fact]
        static void Test2()
        {
            var book2 = new Book("book2");
            book2.AddGrade(101);
            book2.AddGrade(65);
            book2.AddGrade(46);
            book2.AddGrade(86);
            book2.AddGrade(74.5);

            var result2 = book2.GetStatistics();
            Assert.Equal(74.5, result2.Average, 1);
            Assert.Equal(46, result2.Low, 1);
            Assert.Equal(101, result2.High, 1);
        }
        [Fact]
        static void Test3()
        {
            var book3 = new Book("book3");
            book3.AddGrade(15);
            book3.AddGrade(9);
            book3.AddGrade(25);
            book3.AddGrade(84);
            book3.AddGrade(33.25);

            var result3 = book3.GetStatistics();
            Assert.Equal(33.25, result3.Average, 1);
            Assert.Equal(9, result3.Low, 1);
            Assert.Equal(84, result3.High, 1);
        }
        [Fact]
        static void Test4()
        {
            var book4 = new Book("book4");
            book4.AddGrade(47);
            book4.AddGrade(16);
            book4.AddGrade(50);
            book4.AddGrade(64);
            book4.AddGrade(44.25);

            var result4 = book4.GetStatistics();
            Assert.Equal(44.25, result4.Average, 1);
            Assert.Equal(16, result4.Low, 1);
            Assert.Equal(64, result4.High, 1);
        }
        [Fact]
        static void Test5()
        {
            var book5 = new Book("book5");
            book5.AddGrade(76);
            book5.AddGrade(54);
            book5.AddGrade(3);
            book5.AddGrade(51);
            book5.AddGrade(46);

            var result5 = book5.GetStatistics();
            Assert.Equal(46, result5.Average, 1);
            Assert.Equal(3, result5.Low, 1);
            Assert.Equal(76, result5.High, 1);
        }
        [Fact]
        static void Test6()
        {
            var book6 = new Book("book6");
            book6.AddGrade(2);
            book6.AddGrade(31);
            book6.AddGrade(14);
            book6.AddGrade(42);
            book6.AddGrade(22.25);

            var result6 = book6.GetStatistics();
            Assert.Equal(22.25, result6.Average, 1);
            Assert.Equal(2, result6.Low, 1);
            Assert.Equal(42, result6.High, 1);
        }
        [Fact]
        static void Test7()
        {
            var book7 = new Book("book7");
            book7.AddGrade(74);
            book7.AddGrade(37);
            book7.AddGrade(57);
            book7.AddGrade(20);
            book7.AddGrade(47);

            var result7 = book7.GetStatistics();
            Assert.Equal(47, result7.Average, 1);
            Assert.Equal(20, result7.Low, 1);
            Assert.Equal(74, result7.High, 1);
        }




    }
}
