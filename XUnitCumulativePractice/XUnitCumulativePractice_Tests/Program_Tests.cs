using System;
using XUnitCumulativePractice;
using Xunit;

namespace XUnitCumulativePractice_Tests
{
    public class ValidateOneToOneHundredEven_Tests_ffff
    {
        [InlineData("hello", false)]
        [InlineData("0", false)]
        [InlineData("99", false)]

        [Theory]
        public void ValidateOneToOneHundredEvenCases(string initialInput, bool expectedResult)
        {
            // Arrange
            bool outputResult;
            // Act
            outputResult = Program.ValidateOneToOneHundredEven((initialInput));
            // Assert
            Assert.Equal(expectedResult, outputResult);
        }
    }

    public class ValidateOneToOneHundredEven_Tests_tftf
    {
        [InlineData("6", true)]
        [InlineData("-1", false)]
        [InlineData("80", true)]
   
        [Theory]
        public void ValidateOneToOneHundredEvenCases(string initialInput, bool expectedResult)
        {
            // Arrange
            bool outputResult;
            // Act
            outputResult = Program.ValidateOneToOneHundredEven((initialInput));
            // Assert
            Assert.Equal(expectedResult, outputResult);
        }
    }
    
    public class ValidateOneToOneHundredEven_Tests_tfff
    {
        [InlineData("2", true)]
        [InlineData("101", false)]
        [InlineData("1", false)]

        [Theory]
        public void ValidateOneToOneHundredEvenCases(string initialInput, bool expectedResult)
        {
            // Arrange
            bool outputResult;
            // Act
            outputResult = Program.ValidateOneToOneHundredEven((initialInput));
            // Assert
            Assert.Equal(expectedResult, outputResult);
        }
    }
    
    public class ValidateOneToOneHundredEven_Tests_ttff
    {
        [InlineData("100", true)]
        [InlineData("2", true)]
        [InlineData("99", false)]

        [Theory]
        public void ValidateOneToOneHundredEvenCases(string initialInput, bool expectedResult)
        {
            // Arrange
            bool outputResult;
            // Act
            outputResult = Program.ValidateOneToOneHundredEven((initialInput));
            // Assert
            Assert.Equal(expectedResult, outputResult);
        }
    }
    
    public class ValidateOneToOneHundredEven_Tests_tttt
    {
        [InlineData("2", true)]
        [InlineData("66", true)]
        [InlineData("98", true)]

        [Theory]
        public void ValidateOneToOneHundredEvenCases(string initialInput, bool expectedResult)
        {
            // Arrange
            bool outputResult;
            // Act
            outputResult = Program.ValidateOneToOneHundredEven((initialInput));
            // Assert
            Assert.Equal(expectedResult, outputResult);
        }
    }
}