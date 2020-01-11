using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace rht.FizzBuzz
{
    public class FizzBuzz
    {
      public static void GenerateBuzz(int start, int end)
      {
        string process = "FizzBuzz";
        string filename = "FizzBuzzOutput";
        foreach (uint n in Enumerable.Range(start, end))
        {
          string text = "";
          if (n % 3 == 0 && n % 5 == 0)
          {
            text = "FizzBuzz";
          }
          else if (n % 5 == 0)
          {
            text = "Buzz";
          }
          else if (n % 3 == 0)
          {
            text = "Fizz";
          }
          else 
          {
            text = n.ToString();
          }
          Logger.WriteLine(process, filename, text);
        }
      }
    }
}