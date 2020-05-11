using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class TapeEquilibriumTests
    {
        [TestCase(new int[] { 3, 1, 2, 4, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1000, 1000 }, ExpectedResult = 2000)]
        public int Test(int[] A)
        {
            return new TapeEquilibrium().Solution(A);
        }
    }
}
