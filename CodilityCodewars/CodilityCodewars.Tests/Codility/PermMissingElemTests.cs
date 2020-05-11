using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    class PermMissingElemTests
    {


        [TestCase(new int[] { 2,3,1,5 }, ExpectedResult =4)]
        public int test(int[] A)
        {
            return new PermMissingElem().Solution(A);
        }
    }
}
