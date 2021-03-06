using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWord.Models;
using System;
using System.Collections.Generic;

namespace NumToWord.Tests
{
  [TestClass]
  public class NumberTest
  {

    [TestMethod]
    public void Number_ReverseNumber_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ReverseNumber(642);
      // Assert
      Assert.AreEqual("246", result);
    }

    [TestMethod]
    public void Number_GetWord9_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ConvertTripleDigit(9);
      // Assert
      Assert.AreEqual("nine", result);
    }

    [TestMethod]
    public void Number_GetWord22_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ConvertTripleDigit(22);
      // Assert
      Assert.AreEqual("twenty two", result);
    }

    [TestMethod]
    public void Number_GetWord222_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ConvertTripleDigit(222);
      // Assert
      Assert.AreEqual("two hundred twenty two", result);
    }

    [TestMethod]
    public void Number_GetWord11_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ConvertTripleDigit(11);
      // Assert
      Assert.AreEqual("eleven", result);
    }

    [TestMethod]
    public void Number_GetWord20_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ConvertTripleDigit(20);
      // Assert
      Assert.AreEqual("twenty", result);
    }

    [TestMethod]
    public void Number_GetWord830_string()
    {
      // Arrange
      Number newNumber = new Number();
      // Act
      string result = newNumber.ConvertTripleDigit(830);
      // Assert
      Assert.AreEqual("eight hundred thirty", result);
    }

  }
}
