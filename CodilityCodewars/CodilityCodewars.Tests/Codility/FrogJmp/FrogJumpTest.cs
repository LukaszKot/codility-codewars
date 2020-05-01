using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility.FrogJmp
{
    [TestFixture]
    
    public class FrogJumpTest
    {
        [TestCase(10, 85, 30, ExpectedResult = 3)]
        [TestCase(10, 10, 30, ExpectedResult = 0)]
        [TestCase(3, 999111321, 7, ExpectedResult = 142730189)]
        public int Test(int X, int Y, int D)
        {
            return new CodilityCodewars
                    .Codility
                    .FrogJmp
                    .FrogJump()
                    .Solution(X,Y,D);
        }
    }
}
