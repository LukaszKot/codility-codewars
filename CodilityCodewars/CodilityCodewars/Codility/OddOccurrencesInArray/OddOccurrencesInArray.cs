using System.Collections.Generic;
using System.Linq;

namespace CodilityCodewars.Codility.OddOccurrencesInArray
{
    public class OddOccurrencesInArray
    {
        public int Solution(int [] A)
        {
            var dictionary = new Dictionary<int, int>();

            foreach(var n in A)
            {
                if(dictionary.ContainsKey(n))
                {
                    dictionary.Remove(n);
                }
                else
                {
                    dictionary.Add(n, n);
                }
            }

            return dictionary.Keys.First();
        }
    }
}
