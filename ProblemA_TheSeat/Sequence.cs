using System;
using System.Collections.Generic;

namespace ProblemA_TheSeat
{
   public class Sequence
   {
      public Sequence(string input)
      {
         if (input.Length < 2 || input.Length > 1000) throw new ArgumentOutOfRangeException(nameof(input), input.Length, "Input string length must be between 2 and 1000.");
         Sequences = input.ToCharArray();
      }

      public IEnumerable<char> Sequences { get; }
   }
}