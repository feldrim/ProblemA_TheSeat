using System;
using System.Collections.Generic;

namespace ProblemA_TheSeat
{
   public class Sequence
   {
      public Sequence(string input)
      {
         if (input.Length < 2 || input.Length > 1000) throw new ArgumentOutOfRangeException(nameof(input), input.Length, "Input string length must be between 2 and 1000.");
         InitialPosition = input[0];
         var temp = new char[input.Length - 1];
         input.CopyTo(1, temp, 0, input.Length - 1);
         Preferences = temp;
      }

      public char InitialPosition { get; }

      public IEnumerable<char> Preferences { get; }
   }
}