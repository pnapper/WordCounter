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
    public void CompareStrings_CompareWords_True()
    {
      //Arrange
      WordChecker newWord = new WordChecker();

      //action
      var result = newWord.WordCount("run", "run");
      List<string> expected = new List<string> {"run"};

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CompareStrings_CompareWords_False()
    {
      //Arrange
      WordChecker newWord = new WordChecker();

      //action
      var result = newWord.WordCount("run", "jog");
      List<string> expected = new List<string> {"run"};

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
  }
}
