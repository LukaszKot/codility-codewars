using System;
using System.Linq;

namespace CodilityCodewars.Codility
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A)
        {
            var leftSum = A[0];
            var rightSum = A.Sum() - leftSum;
            var minDiff = Math.Abs(leftSum - rightSum);
            for (int i=1; i<A.Length-1; i++)
            {
                leftSum += A[i];
                rightSum -= A[i];
                var diff = Math.Abs(leftSum - rightSum);
                if (minDiff > diff) minDiff = diff;
                if (minDiff == 0) return 0;
            }

            return minDiff;
        }
    }
}
