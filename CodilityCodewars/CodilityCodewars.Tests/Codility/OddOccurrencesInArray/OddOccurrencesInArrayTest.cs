using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityCodewars.Tests.Codility.OddOccurrencesInArray
{
    [TestFixture]
    class OddOccurrencesInArrayTest
    {
        [TestCase(new int[] { 9,3,9,3,9,7,9 }, ExpectedResult = 7)]
        public int test(int[] A)
        {
            var o = new CodilityCodewars.Codility.OddOccurrencesInArray.OddOccurrencesInArray();
            return o.Solution(A);
        }
    }
}
