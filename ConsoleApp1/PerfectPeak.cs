using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    class PerfectPeak
    {
        public int perfectPeak(List<int> A)
        {
            int len = A.Count;

            if (len <= 2)
            {
                return 0;
            }
            for (int i = 1; i < len - 1; i++)
            {
                int leftMax = Max(A.GetRange(0, i - 1), out int maxIndex);
                int rightMin = Min(A.GetRange(i, len - 1), out int minIndex);
                // if(leftMax )
                if (leftMax < A[i] && rightMin > A[i])
                {
                    return 1;
                }

                i = minIndex - 1;
            }
            return 0;
        }
        public int Min(List<int> B, out int index)
        {
            index = 0;
            int min = B[0];
            int len = B.Count;
            if (len == 1)
            {
                return min;
            }
            for (int i = 1; i < len; i++)
            {
                if (min > B[i])
                {
                    min = B[i];
                    index = i;
                }
            }
            return min;
        }

        public int Max(List<int> B, out int index)
        {
            index = 0;
            int max = B[0];
            int len = B.Count;
            if (len == 1)
            {
                return max;
            }
            for (int i = 1; i < len; i++)
            {
                if (max < B[i])
                {
                    max = B[i];
                    index = i;
                }
            }
            return max;
        }
    }
}
