using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] array = new int[] { 1, 1, 2, 3, 3, 4, 7, 10, 10, 12, 15, 16, 16 };
        int[] expected = new int[] { 1, 16, 2, 15, 3, 12, 4, 10, 7 };

        // Act
        int[] result = Pattern.SortInPattern(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = new int[] { 16 };
        int[] expected = new[] { 16 };

        // Act
        int[] result = Pattern.SortInPattern(singleElementArray);

        // Assert
        Assert.That (result, Is.EqualTo(expected));
    }
}