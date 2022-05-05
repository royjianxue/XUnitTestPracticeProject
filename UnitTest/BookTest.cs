using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using GradeBook;

namespace UnitTest
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(50.1);
            book.AddGrade(60.2);
            book.AddGrade(30.1);

            //act
            var result = book.GetStatistics();
            //assert

            Assert.Equal(80.32, result.Average, 1 );
            Assert.Equal(98.32, result.High, 1);
            Assert.Equal(60.32, result.Low, 1);
        }


    }
}
