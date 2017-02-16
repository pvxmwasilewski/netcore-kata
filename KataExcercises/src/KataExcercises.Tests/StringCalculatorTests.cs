using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace KataExcercises.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void AddTwoNumbersShouldReturnSumAsAString()
        {
            //arrange

            //act
            var result = StringCalculator.StringCalculator.Add(2, 5);

            //assert
            Assert.Equal("7", result);
        }
        
    }
}
