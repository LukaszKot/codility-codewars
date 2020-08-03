using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class MaxProductOfThreeTests
    {
        [TestCase(new int[] { -3, 1, 2, -2, 5, 6 }, ExpectedResult = 60)]
        [TestCase(new int[] { -5, 5, -5, 4}, ExpectedResult = 125)]
        public int Test(int[] A)
        {
            return new MaxProductOfThree().Solution(A);
        }
    }
}
