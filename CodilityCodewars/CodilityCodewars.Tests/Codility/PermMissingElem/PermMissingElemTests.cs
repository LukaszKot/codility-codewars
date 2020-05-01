using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilityCodewars.Tests.Codility.PermMissingElem
{
    [TestFixture]
    class PermMissingElemTests
    {


        [TestCase(new int[] { 2,3,1,5 }, ExpectedResult =4)]
        public int test(int[] A)
        {
            return new CodilityCodewars.Codility.PermMissingElem.PermMissingElem().Solution(A);
        }
    }
}
