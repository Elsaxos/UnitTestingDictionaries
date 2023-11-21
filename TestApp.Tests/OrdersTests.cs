using System;
using NUnit.Framework;

namespace TestApp.Tests
{
    public class OrdersTests
    {
        [Test]
        public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[0];

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
        {


        }
        [Test]
        public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
        {
            // Arrange
     
        }

        [Test]
        public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
        {
         
        }
    }
}


