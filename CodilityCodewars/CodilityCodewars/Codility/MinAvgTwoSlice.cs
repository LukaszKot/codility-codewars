using System;

namespace CodilityCodewars.Codility
{
    public class MinAvgTwoSlice
    {
        public int Solution(int[] A)
        {
            long[] prefixSums = new long[A.Length];
            for(var i=0; i<A.Length; i++)
            {
                if(i==0)
                {
                    prefixSums[0] = A[0];
                }
                else
                {
                    prefixSums[i] = prefixSums[i - 1] + A[i];
                }
            }
            double lowestAverage = long.MaxValue;
            var lowestQ = A.Length;
            for (var i=0; i<A.Length-1; i++)
            {
                for(var j=i+1; j<(A.Length<i+3? A.Length : i+3); j++)
                {
                    double average = ((double)prefixSums[j] - (double)(i==0 ? 0 : prefixSums[i - 1]))/(double)(j-i+1);
                    if(average<lowestAverage)
                    {
                        lowestAverage = average;
                        lowestQ = i;
                    }
                }
            }
            return lowestQ;
        }
    }
}
