using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility.CyclicRotation
{
    [TestFixture]
    public class CyclicRotationTests
    {
        [TestCase(new int[] { 3, 8,9,7,6 }, 3, ExpectedResult = new int[] { 9, 7, 6, 3, 8 })]
        [TestCase(new int[] { 0, 0, 0 }, 1, ExpectedResult = new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        public int[] test(int[] array, int k)
        {
            var cyclicRotation = new CodilityCodewars.Codility.CyclicRotation.CyclicRotation();
            return cyclicRotation.Solution(array, k);
        }
    }
}
