using System.Collections.Generic;

namespace CodilityCodewars.Codility
{
    public class PermMissingElem
    {
        public int Solution(int[] A)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach(var n in A)
            {
                dictionary.Add(n, n);
            }
            for(var i=1; i<=A.Length+1; i++)
            {
                if (!dictionary.ContainsKey(i)) return i;
            }

            return 0;
        }
    }
}
