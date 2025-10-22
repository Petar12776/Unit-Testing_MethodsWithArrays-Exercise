using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] mixedArray = new char[] { '1', 'a', 'b', '2', '5', 'c' };
        char[] expected = new char[] { 'a', 'b', 'c' };

        // Act
        char[] result = Fake.RemoveStringNumbers(mixedArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] letterArray = new char[] { 'a', 'b', 'c', 'f', 'g', 'o' };
        char[] expected = new char[] { 'a', 'b', 'c', 'f', 'g', 'o' };

        // Act
        char[] result = Fake.RemoveStringNumbers(letterArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }
}