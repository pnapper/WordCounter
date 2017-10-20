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
    public void CompareWords_CompareString_True()
    {
      //Arrange
      WordChecker newWord = new WordChecker();

      //action
      var result = newWord.Count("run", "run");
      var expected = 1;


      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
