using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemA_TheSeat
{
   public class PolicyFactory
   {
      private readonly char _initialPosition;
      private readonly Dictionary<string, Func<char[], int>> _policies;
      private readonly char[] _preferences;
      private readonly int[] _results;
      
      public PolicyFactory(Sequence sequence)
      {
         _initialPosition = sequence.InitialPosition;
         _preferences = sequence.Preferences.ToArray();
         _policies = GetPolicies();
         _results = new int[_policies.Count];
      }
      
      public int[] GetResults()
      {
         for (var i = 0; i < _results.Length; i++) _results[i] = _policies.ElementAt(i).Value.Invoke(_preferences);

         return _results;
      }

      private Dictionary<string, Func<char[], int>> GetPolicies()
      {
         return new Dictionary<string, Func<char[], int>>
         {
            {"When you leave, always leave the seat up", array => array.Count(pref => pref.Equals('U'))},
            {"When you leave, always leave the seat down", array => array.Count(pref => pref.Equals('D'))},
            {
               "When you leave, always leave the seat as you would like to find it",
               array => array.Count(pref => pref.Equals(_initialPosition))
            }
         };
      }
   }
}