using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] oneIntegerArray = new int[] { 6 } ;
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindFirstRepeatingElement(oneIntegerArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] nonRepeatElementArray = new int[] { 5, 10, 12, 16, 26 };
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindFirstRepeatingElement(nonRepeatElementArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] repeatingNegativeArray = new int[] { -1, -1 };
        int expected = -1;

        // Act 
        int result = RepeatingChecker.FindFirstRepeatingElement(repeatingNegativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Ararnge
        int[] repeatingNegativeArray = new int[] { 7, 7, 7, 7, 7, 7, 7 };
        int expected = 7;

        // Act 
        int result = RepeatingChecker.FindFirstRepeatingElement(repeatingNegativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] repeatingNegativeArray = new int[] { 34, 56, 71, 34, 89 };
        int expected = 34;

        // Act 
        int result = RepeatingChecker.FindFirstRepeatingElement(repeatingNegativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
