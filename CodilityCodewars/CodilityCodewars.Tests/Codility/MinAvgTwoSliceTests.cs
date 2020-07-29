using CodilityCodewars.Codility;
using NUnit.Framework;
using System.Linq;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class MinAvgTwoSliceTests
    {
        [TestCase(new int[] { 4,2,2,5,1,5,8  }, ExpectedResult = 1)]
        [TestCase(new int[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue }, ExpectedResult = 0)]
        [TestCase(new int[] { 10000, 10000, 10000, 10000, 10000, 10000, 10000 }, ExpectedResult = 0)]
        public int Test(int[] A)
        {
            return new MinAvgTwoSlice().Solution(A);
        }
    }
}
