using System;

namespace NumberToWords.Models
{
  public class Words
  {
    public static int scrabbleSolver(char letter)
    {
      switch (Char.ToLower(letter))
      {
        case 'd':
        case 'g':
          return 2;
        case 'b':
        case 'c':
        case 'm':
        case 'p':
          return 3;
        case 'y':
        case 'w':
        case 'v':
        case 'h':
        case 'f':
          return 4;
        case 'k':
          return 5;
        case 'j':
        case 'x':
          return 8;
        case 'z':
        case 'q':
          return 10;
        case ' ':
          return 0;
        default:
          return 1;
      }
    }
    public static int getWordScore(string word)
    {
      int TotalScore = 0;
      foreach (char letter in word)
      {
        TotalScore += Words.scrabbleSolver(letter);
      }
      return TotalScore;
    }

  }
}
