using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordChecker
  {

    public List<string> WordCount(string userWord, string userSentence)
    {

      List<string> countList = new List<string> {};

      string word = userWord.ToUpper();
      userSentence.ToUpper();
      string[] splitWords = userSentence.Split();
          Console.WriteLine(splitWords);

      foreach (string checkWord in splitWords)
        {
          if (userWord == splitWords.ToString())
          {
            countList.Add(checkWord);
            Console.WriteLine(checkWord);
            Console.WriteLine(countList);
            return countList;
          }
          else
          {
            countList.Add("No matches");
            Console.WriteLine("No matches.");
          }


      // if (userWord == wordList)
      // {
      //   countList.Add(userSentence);
      // }
      // else {
      //   countList.Add("No matches");
      // }
      //
      // return countList[];
      }
    }
  }
}
