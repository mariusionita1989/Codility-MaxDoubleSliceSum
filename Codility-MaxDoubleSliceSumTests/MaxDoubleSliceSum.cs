using Codility_MaxDoubleSliceSum;

namespace Codility_MaxDoubleSliceSumTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestSampleInput()
        {
            Solution solution = new Solution();
            int[] A = { 3, 2, 6, -1, 4, 5, -1, 2 };
            int expected = 17;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMinimumInput()
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3 };
            int expected = 0; // N=3, so there is no double slice
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllNegativeValues()
        {
            Solution solution = new Solution();
            int[] A = { -3, -2, -6, -1, -4, -5, -1, -2 };
            int expected = 0; // The maximum double slice sum is 0
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllPositiveValues()
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3, 4, 5, 6, 7 };
            int expected = 18; // The maximum double slice sum is 20 (3 + 4 + 5 + 6 + 7)
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLargeInput()
        {
            Solution solution = new Solution();
            int[] A = new int[Solution.RANGE_HIGHEST_VALUE];
            for (int i = 0; i < Solution.RANGE_HIGHEST_VALUE; i++)
                A[i] = 10000;
            
            int expected = 999700000; // The maximum double slice sum is 10000 * (RANGE_HIGHEST_VALUE - 2)
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}