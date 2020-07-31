using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class DistinctTests
    {
        [TestCase(new int[] { 2,1,1,2,3,1 }, ExpectedResult = 3)]
        public int Test(int[] A)
        {
            return new Distinct().Solution(A);
        }
    }
}
