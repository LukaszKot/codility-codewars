using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class CountDivTests
    {
        [TestCase(6,11,2, ExpectedResult = 3)]
        [TestCase(6, 11, 3, ExpectedResult = 2)]
        [TestCase(6, 11, 4, ExpectedResult = 1)]
        [TestCase(4, 12, 4, ExpectedResult = 3)]
        [TestCase(1000001,120000000,1000000, ExpectedResult= 119)]
        [TestCase(1000000, 119999999, 1000000, ExpectedResult = 119)]
        [TestCase(1000000, 1200000000, 1000000, ExpectedResult = 1200)]
        [TestCase(1000000, 1200000000, 10000000, ExpectedResult = 120)]
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, ExpectedResult = 1)]
        public int Tests(int A, int B, int K)
        {
            return new CountDiv().Solution(A, B, K);
        }
    }
}
