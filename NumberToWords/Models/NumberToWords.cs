using System;
using System.Collections.Generic;

namespace NumberToWords.Models
{
  public class Words
  {
    public string Input { get; set; }
    public Words(string input)
    {
      Input = input;
    }
    public char[] ToArray(string input)
    {
      char[] array = input.ToCharArray();
      return array;
    }
    public int CheckPoints(char[] array)
    {
      return 13;
    }
    // public static Dictionary<string, int> scrabbleWords = new Dictionary<string, int>()
    // {
    //   {"A", 1},
    //   {"D", 2},
    //   {"B", 3}

    // };

  }
}