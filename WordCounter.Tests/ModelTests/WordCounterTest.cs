using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{

  [TestClass]
  public class WordCounterTest
  {

    [TestMethod]
    public void CompareWords_CountRepeats_Total()
    {
      //Arrange
      CountWords newWord = new CountWords("run", "run");
      var expected = 1;

      //action
      // var result = newWord.WordChecker("run", "run");
      int result = newWord.RepeatCounter();

      //Assert
      Assert.AreEqual(expected, result);
      Console.WriteLine(result);
    }

    [TestMethod]
    public void CompareWords_CountRepeats_Total2()
    {
      //Arrange
      CountWords newWord = new CountWords("run", "jog");
      var expected = 0;

      //action
      int result = newWord.RepeatCounter();

      //Assert
      Assert.AreEqual(expected, result);
      Console.WriteLine(result);
    }

    [TestMethod]
    public void CompareWords_CountRepeats_Total3()
    {
      //Arrange
      CountWords newWord = new CountWords("run", "See Jane run");
      var expected = 1;

      //action
      int result = newWord.RepeatCounter();

      //Assert
      Assert.AreEqual(expected, result);
      Console.WriteLine(result);
    }

    [TestMethod]
    public void CompareWords_CountRepeats_Total4()
    {
      //Arrange
      CountWords newWord = new CountWords("run", "See Jane run and run");
      var expected = 2;

      //action
      int result = newWord.RepeatCounter();

      //Assert
      Assert.AreEqual(expected, result);
      Console.WriteLine(result);
    }
  }
}
