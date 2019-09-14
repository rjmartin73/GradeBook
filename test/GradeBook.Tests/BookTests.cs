using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {   /*
                Break tests up into 3 sections arrange, act and assert
             */

            // arrange section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
           
            // act section
            var result = book.GetStatistics();
            
            // assert section
            Assert.Equal(85.6, result.Average, 1);            
            Assert.Equal(77.3, result.Low, 1);            
            Assert.Equal(90.5, result.High, 1);            
        }
    }
}
