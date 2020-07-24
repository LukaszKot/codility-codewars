using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class GenomicRangeQueryTests
    {
        [TestCase("CAGCCTA", new int[] { 2,5,0 }, new int[] { 4,5,6 }, ExpectedResult = new int[] { 2,4,1 })]
        public int[] Test(string S, int[] P, int[] Q)
        {
            return new GenomicRangeQuery().Solution(S, P, Q);
        }
    }
}
