using System.Collections.Generic;

namespace CodilityCodewars.Codility
{
    public class FrogRiverOne
    {
        public int Solution(int X, int[] A)
        {
            var dictionary = new Dictionary<int, int>();
            for(int i=0; i<A.Length; i++)
            {
                if(dictionary.ContainsKey(A[i]))
                {
                    if(dictionary[A[i]]>i)
                    {
                        dictionary[A[i]] = i;
                    }
                }
                else
                {
                    dictionary.Add(A[i], i);
                }
            }
            int max = 0;
            for(int i=1; i<=X; i++)
            {
                if (!dictionary.ContainsKey(i))
                    return -1;
                if (max < dictionary[i])
                    max = dictionary[i];
            }
            return max;
        }
    }
}
