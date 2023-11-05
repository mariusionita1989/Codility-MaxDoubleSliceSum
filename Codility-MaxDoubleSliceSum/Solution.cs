using System.Runtime.CompilerServices;

namespace Codility_MaxDoubleSliceSum
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 3;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                if (N == 3)
                    return 0; // There is no double slice for N=3

                // Calculate the maximum sum of double slices ending at each index
                int[] maxEndingHere = new int[N];
                for (int i = 1; i < N - 1; i++)
                    maxEndingHere[i] = Math.Max(maxEndingHere[i - 1] + A[i], 0);

                // Calculate the maximum sum of double slices starting from each index
                int[] maxStartingHere = new int[N];
                for (int i = N - 2; i > 0; i--)
                    maxStartingHere[i] = Math.Max(maxStartingHere[i + 1] + A[i], 0);

                // Calculate the maximum double slice sum with Y as the middle point
                int maxDoubleSliceSum = 0;
                for (int i = 1; i < N - 1; i++)
                    maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, maxEndingHere[i - 1] + maxStartingHere[i + 1]);

                return maxDoubleSliceSum;
            }

            return int.MaxValue;
        }
    }
}
