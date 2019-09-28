using System;
using Xunit;
using GradeBook;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        {   
            var book1 = GetGook("Book 1");    
            var book2 = GetGook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

         Book GetGook(string name)
        {
            return new Book(name);
            
        }
    }
}
