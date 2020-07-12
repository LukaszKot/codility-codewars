using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class CountingNumbersTests
    {
        [TestCase(new int[] { 1,3,6,4,1,2 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 4)]
        [TestCase(new int[] { -1, -3 }, ExpectedResult = 1)]
        public int test(int[] A)
        {
            return new CountingNumbers().Solution(A);
        }
    }
}
