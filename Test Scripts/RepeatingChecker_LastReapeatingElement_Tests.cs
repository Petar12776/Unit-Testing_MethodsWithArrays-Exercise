using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindLastRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] oneIntegerArray = new int[] { 100 };
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindLastRepeatingElement(oneIntegerArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] nonRepeatElementArray = new int[] { 501, 116, 301,789, 260 };
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindLastRepeatingElement(nonRepeatElementArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] repeatingNegativeArray = new int[] { -1, -1 };
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindLastRepeatingElement(repeatingNegativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] repeatingNegativeArray = new int[] { 950, 950, 950, 950, 950, 90, 950 };
        int expected = 950;

        // Act 
        int result = RepeatingChecker.FindLastRepeatingElement(repeatingNegativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange 
        int[] repeatingNegativeArray = new int[] { 456, 561, 743, 312, 899, 456 };
        int expected = 456;

        // Act 
        int result = RepeatingChecker.FindLastRepeatingElement(repeatingNegativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}