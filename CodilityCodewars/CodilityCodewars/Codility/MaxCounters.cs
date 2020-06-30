using System.Linq;

namespace CodilityCodewars.Codility
{
    public class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            int[] counters = Enumerable.Repeat(0, N).ToArray();
            int currentMax = 0;
            int lastUpdate = 0;
            foreach(var operation in A)
            {
                if(operation==N+1)
                {
                    lastUpdate = currentMax;
                }
                else
                {
                    if(counters[operation - 1]>lastUpdate)
                    {
                        counters[operation - 1]++;
                    }
                    else
                    {
                        counters[operation - 1] = lastUpdate + 1;
                    }
                    
                    if (currentMax < counters[operation - 1]) currentMax = counters[operation - 1];
                }
            }
            return counters.Select(x => {
                if (x > lastUpdate) return x;
                else return lastUpdate;
            }).ToArray();
        }
    }
}
