using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class FrogRiverOneTests
    {
        [TestCase(5, new int[] { 1,3,1,4,2,3,5,4 }, ExpectedResult = 6)]
        [TestCase(1, new int[] { }, ExpectedResult =-1)]
        [TestCase(1, new int[] { 1 }, ExpectedResult = 0)]
        public int Test(int X, int[] A)
        {
            return new FrogRiverOne().Solution(X, A);
        }
    }
}
