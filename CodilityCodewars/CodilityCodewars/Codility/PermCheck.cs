using System.Linq;

namespace CodilityCodewars.Codility
{
    public class PermCheck
    {
        public int Solution(int[] A)
        {
            int check = 1;
            foreach(var el in A.OrderBy(x => x))
            {
                if (check != el) return 0;
                check++;
            }
            return 1;
        }
    }
}
