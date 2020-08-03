using System;
using System.Linq;

namespace CodilityCodewars.Codility
{
    public class MaxProductOfThree
    {
        public int Solution(int[] A)
        {
            Array.Sort(A);
            int first;
            int second = 1;

            foreach (var n in A.Skip(A.Length - 3))
            {
                second *= n;
            }

            if (A[0]*A[1]>0)
            {
                first = A[0] * A[1] * A[A.Length - 1];
                if (first > second) return first;
                return second;
            }

            
            return second;
            
        }
    }
}
