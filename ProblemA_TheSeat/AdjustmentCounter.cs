using System.Linq;

namespace ProblemA_TheSeat
{
   public class AdjustmentCounter
   {
      private readonly char[] _preferences;
      private readonly int[] _results;

      public AdjustmentCounter(Sequence sequence)
      {
         _preferences = sequence.Sequences.ToArray();
         _results = new int[3];
      }

      public int[] GetResults()
      {
         for (var i = 1; i < _preferences.Length; i++)
         {
            //policy 1: Always U
            CountAdjustments(i == 1 ? _preferences[0] : 'U', _preferences[i], 'U', 0);

            //policy 2: Always D
            CountAdjustments(i == 1 ? _preferences[0] : 'D', _preferences[i], 'D', 1);

            //policy 3: Same as before
            CountAdjustments(_preferences[i - 1], _preferences[i], _preferences[i], 2);
         }

         return _results;
      }

      private void CountAdjustments(char before, char current, char after, int policyNumber)
      {
         if (before != current) _results[policyNumber]++;
         if (current != after) _results[policyNumber]++;
      }
   }


}