using System;

namespace ProblemA_TheSeat
{
   public static class Program
   {
      public static void Main(string[] args)
      {
         var line = Console.ReadLine();
         var seq = new Sequence(line);
         var pf = new PolicyFactory(seq);

         foreach (var result in pf.GetResults())
         {
            Console.WriteLine(result);
         }
      }
   }
}
