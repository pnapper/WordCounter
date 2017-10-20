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
    }

    // [TestMethod]
    // public void CompareStrings_CompareWords_False()
    // {
    //   //Arrange
    //   WordChecker newWord = new WordChecker();
    //
    //   //action
    //   var result = newWord.WordCount("run", "jog");
    //   List<string> expected = new List<string> {"run"};
    //
    //   //Assert
    //   CollectionAssert.AreEqual(expected, result);
    // }
  }
}
