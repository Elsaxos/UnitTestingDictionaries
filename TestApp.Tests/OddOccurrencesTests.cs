using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
         string[] input = Array.Empty<string>();
        
        string result = OddOccurrences.FindOdd(input);
         
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] input = new string[] {"the", "the"};

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = new string[] { "the", "the", "the" };

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.EqualTo("the"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = new string[] { "the","the","the","me", "that", "a", "a", "a", "this","this" };

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.EqualTo("the me that a"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = new string[] { "The", "tHe", "tHE", "Me", "that", "A", "A", "a", "THIS", "this" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the me that a").IgnoreCase);
    }
}
