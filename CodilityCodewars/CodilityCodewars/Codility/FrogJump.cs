using System;

namespace CodilityCodewars.Codility
{
    public class FrogJump
    {
        public int Solution(int X, int Y, int D)
        {
            double overallDistance = Y - X;
            double jumps = overallDistance / (double)D;
            return (int)Math.Ceiling(jumps);
        }
    }
}
