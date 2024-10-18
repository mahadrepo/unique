using Xunit;
using Moq;
using AddNumbersApp;

namespace AddNumbersApp.Tests
{
    public class AddNumbersTests
    {
        [Fact]
        public void AddTwoNumbers_ShouldReturnSum_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = AddNumbers.AddTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void SubtractTwoNumbers_ShouldReturnDifference_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            int result = AddNumbers.SubtractTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void MultiplyTwoNumbers_ShouldReturnProduct_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = AddNumbers.MultiplyTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void DivideTwoNumbers_ShouldReturnQuotient_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            double result = AddNumbers.DivideTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void DivideTwoNumbers_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            int num1 = 10;
            int num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => AddNumbers.DivideTwoNumbers(num1, num2));
        }
    }
}
