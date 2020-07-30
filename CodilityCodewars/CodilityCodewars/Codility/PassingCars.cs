namespace CodilityCodewars.Codility
{
    public class PassingCars
    {
        public int Solution(int[] A)
        {
            var prefixSum = new int[A.Length];
            for(var i=0; i<prefixSum.Length; i++)
            { 
                if(i > 0)
                {
                    prefixSum[i] = prefixSum[i - 1];
                }
                if(A[i]==1) prefixSum[i]++;
            }

            var result = 0;
            for(var i=0; i<A.Length; i++)
            {
                if(A[i]==0)
                {
                    result += prefixSum[A.Length - 1] - prefixSum[i];
                    if (result > 1000000000) return -1;
                }
            }
            return result;
        }
    }
}
