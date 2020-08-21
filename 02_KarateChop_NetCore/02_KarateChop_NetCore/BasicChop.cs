using System;
using System.Collections.Generic;

namespace _02_KarateChop_NetCore
{
    public class BasicChop
    {
        public int Chop(int searchTarget, int[] sortedNumbers)
        {
            int currentMinIndex = 0;
            int currentMaxIndex = sortedNumbers.Length - 1;
            
            while(currentMinIndex <= currentMaxIndex)
            {
                int currentMiddleIndex = (currentMinIndex + currentMaxIndex) / 2;

                if (searchTarget == sortedNumbers[currentMiddleIndex])
                {
                    return currentMiddleIndex;
                }
                else if(searchTarget < sortedNumbers[currentMiddleIndex])
                {
                    currentMaxIndex = currentMiddleIndex - 1;
                }
                else if (searchTarget > sortedNumbers[currentMiddleIndex])
                {
                    currentMinIndex = currentMiddleIndex + 1;
                }
            }

            return -1;
        }
    }
}
