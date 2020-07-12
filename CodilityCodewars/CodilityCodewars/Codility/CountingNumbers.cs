using System.Linq;

namespace CodilityCodewars.Codility
{
    public class CountingNumbers
    {
        public int Solution(int[] A)
        {
            return Enumerable.Range(1,1000000).Except(A).First();
        }
    }
}
