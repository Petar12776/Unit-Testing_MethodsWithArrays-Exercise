using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] uniqueNumbers = new int[] { 1, 2, 3, 4, 5 };
        int[] expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(uniqueNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] mixedArray = new int[] { 1, 2, 3, 3, 4, 5, 5, 6 };
        int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(mixedArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] duplicateArray = new int[] { 6, 6, 6, 6, 6 };
        int[] expected = new int[] { 6 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(duplicateArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}