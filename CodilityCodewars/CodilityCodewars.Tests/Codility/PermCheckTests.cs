using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class PermCheckTests
    {
        [TestCase(new int[] { 4,1,3,2 }, ExpectedResult = 1)]
        [TestCase(new int[] { 4, 1, 3 }, ExpectedResult = 0)]
        public int Test(int[] A)
        {
            return new PermCheck().Solution(A);
        }
    }
}
