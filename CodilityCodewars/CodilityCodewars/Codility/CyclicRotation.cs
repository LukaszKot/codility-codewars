using System.Collections.Generic;
using System.Linq;

namespace CodilityCodewars.Codility
{
    public class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        {
            if (A.Length == 0) return A;
            var q = new Queue<int>(A.Reverse());
            var moves = K % A.Length;
            for(var i=0; i< moves; i++)
            {
                q.Enqueue(q.Dequeue());
            }
            return q.Reverse().ToArray();
        }
    }
}
