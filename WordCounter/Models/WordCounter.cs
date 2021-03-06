using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputWord;
    private string _inputSentence;

    public RepeatCounter(string inputWord, string inputSentence)
    {
      _inputWord = inputWord;
      _inputSentence = inputSentence;
    }

    public string GetInputWord()
    {
      return _inputWord;
    }
    public void SetInputWord(string newInputWord)
    {
      _inputWord = newInputWord;
    }

    public string GetInputSentence()
    {
      return _inputSentence;
    }
    public void SetInputSentence(string newInputSentence)
    {
      _inputSentence = newInputSentence;
    }

    public int CountMatching()
    {
      int count = 0;
      string[] temp = _inputSentence.ToLower().Split(' ', ',','.','-','+','=','*','/', '_',':',';');
      for(int i = 0; i < temp.Length; i++)
      {
        if (_inputWord == temp[i])
        {
          count++;
        }

      }
      return count;
    }
  }
 }

  // public class Program
  //   {
  //     public static void Main()
  //     {
  //       Console.WriteLine("Enter a word");
  //       string inputWord = Console.ReadLine();
  //       Console.WriteLine("Enter a sentence or list of words");
  //       string inputSentence = Console.ReadLine();
  //
  //       RepeatCounter newRepeatCounter = new RepeatCounter(inputWord, inputSentence);
  //
  //       int count = newRepeatCounter.CountMatching();
  //
  //       Console.WriteLine("The word *" + inputWord + "*" + " was entered " + count + " times");
  //     }
  //   }
