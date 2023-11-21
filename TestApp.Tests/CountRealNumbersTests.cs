using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class CountRealNumbersTests
    {
        [Test]
        public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            int[] emptyArray = new int[] { };

            // Act
            string result = CountRealNumbers.Count(emptyArray);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void Test_Count_WithSingleNumber_ShouldReturnCountString()
        {
            // Arrange
            int[] singleNumberArray = new int[] { 5 };

            // Act
            string result = CountRealNumbers.Count(singleNumberArray);

            // Assert
            Assert.AreEqual("5 -> 1", result);
        }

        [Test]
        public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] multipleNumbersArray = new int[] { 5, 5, 10, 10, 20 };

            // Act
            string result = CountRealNumbers.Count(multipleNumbersArray);

            // Assert
            Assert.AreEqual("5 -> 2\r\n10 -> 2\r\n20 -> 1", result);
        }

        [Test]
        public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] negativeNumbersArray = new int[] { -5, -5, -10, -10, -20 };

            // Act
            string result = CountRealNumbers.Count(negativeNumbersArray);

            // Assert
            Assert.AreEqual("-20 -> 1\r\n-10 -> 2\r\n-5 -> 2", result);
        }

        [Test]
        public void Test_Count_WithZero_ShouldReturnCountString()
        {
            // Arrange
            int[] zeroArray = new int[] { 0, 0, 0 };

            // Act
            string result = CountRealNumbers.Count(zeroArray);

            // Assert
            Assert.AreEqual("0 -> 3", result);
        }
    }
}
