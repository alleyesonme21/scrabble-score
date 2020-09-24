using System;
using System.Collections.Generic;
using NumberToWords.Models;


namespace NumberToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("type your word in to see your score: ");
      string input = Console.ReadLine(); //have 'string input' populating with what the user provides (string). 
      Console.WriteLine("The score is " + Words.getWordScore(input)); //we have called on the class 'Words' then called on the method inside of the class
    //'.getWordScore' then populated with 'input' which is what the method needs to run. 
    }
  }
}
