using System.Collections;
using System.Collections.Generic;

namespace CodilityCodewars.Codility
{
    public class GenomicRangeQuery
    {
        private IDictionary<char,int> dictionary = new Dictionary<char,int>
        {
            ['A'] = 1,
            ['C'] = 2,
            ['G'] = 3,
            ['T'] = 4
        };

        public int[] Solution(string S, int[] P, int[] Q)
        {
            var prefixSums = new int[S.Length, 4];
            for(var i=0; i<S.Length; i++)
            {
                if(i==0)
                {
                    prefixSums[i, dictionary[S[i]] - 1] = dictionary[S[i]];
                }
                else
                {
                    for(var j=0; j<4; j++)
                    {
                        prefixSums[i, j] += prefixSums[i - 1, j];
                    }

                    prefixSums[i, dictionary[S[i]] - 1] += dictionary[S[i]];
                }
            }

            int[] result = new int[Q.Length];
            for (var i = 0; i < P.Length; i++)
            {
                foreach(var key in dictionary.Keys)
                {
                    if(prefixSums[Q[i],dictionary[key]-1] - (P[i]-1<0 ? 0 :  prefixSums[P[i]-1, dictionary[key] - 1]) > 0)
                    {
                        result[i] = dictionary[key];
                        break;
                    }
                }
            }
            return result;
        }

    }
}
