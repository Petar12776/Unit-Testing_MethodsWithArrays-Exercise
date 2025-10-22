using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        TopIntegers topIntegers = new TopIntegers();
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = topIntegers.FindTopIntegers(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        TopIntegers topIntegers = new TopIntegers();
        int[] topElementsArray = new int[] { 10, 6, 4, 3 };
        string expected = "10 6 4 3";

        // Act
        string result = topIntegers.FindTopIntegers(topElementsArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        TopIntegers topIntegers = new TopIntegers();
        int[] topElementsArray = new int[] { 200 };
        string expected = "200";

        // Act
        string result = topIntegers.FindTopIntegers(topElementsArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        TopIntegers topIntegers = new TopIntegers();
        int[] topElementsArray = new int[] { 23, 67, 38, 89, 12, 20, 13 };
        string expected = "89 20 13";

        // Act
        string result = topIntegers.FindTopIntegers(topElementsArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}