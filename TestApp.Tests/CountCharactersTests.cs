using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        List<string> input = new() {"", "" ,""};

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new() { "a"};

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "aabbcd", "abcdd" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 3");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 2");
        sb.AppendLine("d -> 3");
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "aabbc!!AA@2", "a!b2@!cA2" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 3");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 2");
        sb.AppendLine("! -> 4");
        sb.AppendLine("A -> 3");
        sb.AppendLine("@ -> 2");
        sb.AppendLine("2 -> 3");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void Test_Count_SpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "aabbcA123", "abc32ABC","123aBB23a","ABC123","BCA321" };
        StringBuilder sb = new();
        sb.AppendLine("a -> 5");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 2");
        sb.AppendLine("A -> 4");
        sb.AppendLine("1 -> 4");
        sb.AppendLine("2 -> 6");
        sb.AppendLine("3 -> 6");
        sb.AppendLine("B -> 5");
        sb.AppendLine("C -> 3");
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
