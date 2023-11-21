using NUnit.Framework;
using TestApp; // Ако Miner е в различен namespace, добавете правилния using statement.

namespace TestApp.Tests
{
    public class MinerTests
    {
        [Test]
        public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[0];

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "gOld 8", "silVer 30" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo("gold -> 8\r\nsilver -> 30"));
        }

        [Test]
        public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
        {
            // Arrange
            string[] input = new string[] { "gOld 8", "silVer 30", "cooper 12", "gold 10", "silver 20" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo("gold -> 18\r\nsilver -> 50\r\ncooper -> 12"));
        }
    }
}
