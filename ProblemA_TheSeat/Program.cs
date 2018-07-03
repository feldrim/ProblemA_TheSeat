using System;

namespace ProblemA_TheSeat
{
   public static class Program
   {
      public static void Main(string[] args)
      {
         var line = Console.ReadLine();
         var seq = new Sequence(line);
         var ac = new AdjustmentCounter(seq);

         foreach (var result in ac.GetResults()) Console.WriteLine(result);
      }
   }
}
