using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class CountWords
  {
    private string _word;
    private string _sentence;

    public CountWords(string word, string sentence)
    {
      _word = word.ToString();
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public int RepeatCounter()
    {
      var wordTotal = 0;
      string[] splitWords = _sentence.Split();
      foreach(string matchWord in splitWords)
      {
        if(_word == matchWord.ToString())
        {
          wordTotal += 1;
        }
      }
      return wordTotal;
    }
  }
}

      //
      // string word = userWord.ToUpper();
      // userSentence.ToUpper();
      // string[] splitWords = userSentence.Split();
      //     Console.WriteLine(splitWords);
      //
      // foreach (string checkWord in splitWords)
      //   {
      //     if (checkWord == word)
      //     {
      //       countList.Add(checkWord);
      //       Console.WriteLine(checkWord);
      //       Console.WriteLine(countList);
      //       return countList;
      //     }
      //     else
      //     {
      //       countList.Add("No matches");
      //       Console.WriteLine("No matches.");
      //       return countList;
      //     }


      // if (userWord == wordList)
      // {
      //   countList.Add(userSentence);
      // }
      // else {
      //   countList.Add("No matches");
      // }
      //
      // return countList[];
//       }
//     }
//   }
// }
