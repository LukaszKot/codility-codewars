using System;

namespace CodilityCodewars.Codility
{
    public class CountDiv
    {
        public int Solution(int A, int B, int K)
        {
            var firstSearchedNumber = 0;
            for(long i=A; i<=((long)A+(long)K);i++)
            {
                if (i % K == 0)
                {
                    firstSearchedNumber = (int)i;
                    break;
                }
            }

            return (int)Math.Floor(((double)B -(double)firstSearchedNumber) / (double)K)+1;
        }
    }
}
