using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemA_TheSeat.Tests
{
   [TestClass]
   public class TheSeatTests
   {
      [TestMethod]
      public void SampleDataTest()
      {
         const string input = "UUUDDUDU";
         var sequence = new Sequence(input);

         var policyFactory = new PolicyFactory(sequence);
         var results = policyFactory.GetResults();

         Assert.AreEqual(new[] {6, 7, 4}, results);
      }
   }
}