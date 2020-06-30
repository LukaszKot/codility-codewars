using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class MaxCountersTests
    {
        [TestCase(5,new int[] { 3,4,4,6,1,4,4 }, ExpectedResult = new int[] { 3, 2, 2, 4, 2 })]
        public int[] Test(int N, int[] A)
        {
            return new MaxCounters().Solution(N, A);
        }
    }
}
