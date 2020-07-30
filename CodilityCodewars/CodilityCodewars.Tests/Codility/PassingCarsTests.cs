using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class PassingCarsTests
    {
        [TestCase(new int[] { 0, 1, 0, 1, 1 }, ExpectedResult = 5)]
        public int Test(int[] A)
        {
            return new PassingCars().Solution(A);
        }
    }
}
