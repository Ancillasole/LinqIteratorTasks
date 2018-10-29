using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Necklace
    {
        public int[] arr = { 1, 2, 3, 0, 5, 6, 7,4 };

        public int LongestNecklace()
        {
            int longestCount = 0;
            int startOfNeckLace = 0;
            int countOfBead = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == startOfNeckLace)
                {
                    if (countOfBead > longestCount)
                    {
                        longestCount = countOfBead;
                    }
                    break;
                }
                else if (arr[i] == i + 1)
                {
                    countOfBead++;
                }
                else
                {
                    return 0;
                }
            }
            return longestCount;
        } 
    }
}
