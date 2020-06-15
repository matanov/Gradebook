using System;
using Xunit;

namespace GradeBook.Tests
{
    public class Booktests
    {
        // [Fact]
        // public void TestAddingIllegalvalue()
        // {
        //     var book = new Book("");
        //     book.AddGrade(105);

        //     Assert.Equal(book.AddGrade(105),"Invalid Value")
        // }
        
        
        
        
        
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //Arrange
           var book = new Book("");
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.3);


           
            //Act

            var result = book.GetStatistics();

            
            //Assert
            Assert.Equal(85.6,result.Average,1);
            Assert.Equal(90.5,result.High,1);
            Assert.Equal(77.3, result.Low,1);
            Assert.Equal('B',result.Letter);

            
        }
    }
}
