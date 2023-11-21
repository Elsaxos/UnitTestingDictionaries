using NUnit.Framework;

using System;
using System.Numerics;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] plants = new string[0];

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[]
        {
          "@--\\-"
        };
        // Act
        string result = Plants.GetFastestGrowing(plants);

        Assert.That(result, Is.EqualTo("Plants with 5 letters:\r\n@--\\-"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        string[] plants = new string[]
        {
          "@--\\-",
          "*---",
          "-----"

        };
        // Act
        string result = Plants.GetFastestGrowing(plants);

        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\n*---\r\nPlants with 5 letters:\r\n@--\\-\r\n-----"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        string[] plants = new string[]
     {
          "@--\\-1W-"
     };
        // Act
        string result = Plants.GetFastestGrowing(plants);

        Assert.That(result, Is.EqualTo("Plants with 8 letters:\r\n@--\\-1W-"));
    }
}
