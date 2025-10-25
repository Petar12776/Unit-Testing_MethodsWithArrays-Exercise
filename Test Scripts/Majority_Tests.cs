using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] ArrayWithZeros = new int[] { 0, 0, 0, 0 } ;
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(ArrayWithZeros);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] equalArray = new int[] { 2, 4, 3, 5, 6, 7 } ;
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(equalArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] evenMajority = new int[] { 2, 4, 6, 10, 12, 7, 5 };
        int expected = 3;

        // Act
        int result = Majority.IsEvenOrOddMajority(evenMajority);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] oddMajority = new int[] { 3, 5, 7, 9, 11, 13, 10, 12 };
        int expected = -4;

        // Act
        int result = Majority.IsEvenOrOddMajority(oddMajority);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}