using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberToWords.Models;
using System;

namespace NumberToWords.Tests
{
  [TestClass]

  public class NumberToWordsTests
  {
    [TestMethod]
    public void WordsConstructor_CreatesInstanceOfWord_Word()
    {
      Words newWord = new Words("test");
      Assert.AreEqual(typeof(Words), newWord.GetType());
    }
    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      //Arrange
      string input = "Walk";

      //Act
      Words newWord = new Words(input);
      string result = newWord.Input;

      //Assert
      Assert.AreEqual(input, result);
    }
    [TestMethod]
    public void GetWord_ReturnsWord_array()
    {
      //Arrange
      string input = "Walk";
      Words newWord = new Words(input);

      //Act

      char[] array = input.ToCharArray();
      char[] result = newWord.ToArray(input);
      Console.WriteLine(result);

      //Assert
      CollectionAssert.AreEqual(array, result);
    }
    [TestMethod]
    public void GetWord_Returnspoints_int()
    {
      //Arrange
      string input = "Walk";
      Words newWord = new Words(input);
      char[] array = newWord.ToArray(input);

      //Act
      //method called on to check array against a dictionary int 
      int points = newWord.CheckPoints(array);
      int result = 13;
      Console.WriteLine(result);

      //Assert
      Assert.AreEqual(points, result);
    }
  }
}