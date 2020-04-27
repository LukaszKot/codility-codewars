using System;

namespace CodilityCodewars.Codility.BinaryGap
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            var nAsString = Convert.ToString(N, 2);

            var maxGapLenght = 0;
            var gapLenght = -1;
            var inGap = false;

            for(int i=1; i<nAsString.Length; i++)
            {
                if(inGap)
                {
                    if(nAsString[i]=='0')
                    {
                        gapLenght++;
                    }
                    else
                    {
                        if(maxGapLenght<gapLenght)
                        {
                            maxGapLenght = gapLenght;
                        }
                        gapLenght = -1;
                        inGap = false;
                    }
                }
                else
                {
                    if(nAsString[i]=='0' && nAsString[i-1]=='1')
                    {
                        inGap = true;
                        gapLenght = 1;
                    }
                }
            }

            return maxGapLenght;
        }
    }
}
