using CodilityCodewars.Codility;
using NUnit.Framework;

namespace CodilityCodewars.Tests.Codility
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void given_1041_returns_5()
        {
            var binaryGap = new BinaryGap();
            Assert.AreEqual(5,binaryGap.Solution(1041));
        }

        [Test]
        public void given_9_returns_2()
        {
            var binaryGap = new BinaryGap();
            Assert.AreEqual(2, binaryGap.Solution(9));
        }

        [Test]
        public void given_529_returns_4()
        {
            var binaryGap = new BinaryGap();
            Assert.AreEqual(4, binaryGap.Solution(529));
        }

        [Test]
        public void given_20_returns_1()
        {
            var binaryGap = new BinaryGap();
            Assert.AreEqual(1, binaryGap.Solution(20));
        }

        [Test]
        public void given_15_returns_0()
        {
            var binaryGap = new BinaryGap();
            Assert.AreEqual(0, binaryGap.Solution(15));
        }

        [Test]
        public void given_561892_returns_0()
        {
            var binaryGap = new BinaryGap();
            Assert.AreEqual(3, binaryGap.Solution(561892));
        }
    }
}
