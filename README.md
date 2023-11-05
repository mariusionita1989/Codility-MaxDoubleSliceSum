# Codility-MaxDoubleSliceSum
A non-empty array A consisting of N integers is given.</br>
A triplet (X, Y, Z), such that 0 ≤ X < Y < Z < N, is called a double slice.</br>
The sum of double slice (X, Y, Z)</br>
is the total of A[X + 1] + A[X + 2] + ... + A[Y − 1] + A[Y + 1] + A[Y + 2] + ... + A[Z − 1].

For example, array A such that:</br>
A[0] = 3</br>
A[1] = 2</br>
A[2] = 6</br>
A[3] = -1</br>
A[4] = 4</br>
A[5] = 5</br>
A[6] = -1</br>
A[7] = 2</br>
contains the following example double slices:</br>
double slice (0, 3, 6), sum is 2 + 6 + 4 + 5 = 17,</br>
double slice (0, 3, 7), sum is 2 + 6 + 4 + 5 − 1 = 16,</br>
double slice (3, 4, 5), sum is 0.</br>
The goal is to find the maximal sum of any double slice.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A consisting of N integers,</br>
returns the maximal sum of any double slice.

For example, given:</br>
A[0] = 3</br>
A[1] = 2</br>
A[2] = 6</br>
A[3] = -1</br>
A[4] = 4</br>
A[5] = 5</br>
A[6] = -1</br>
A[7] = 2</br>
the function should return 17,</br> 
because no double slice of array A has a sum of greater than 17.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [3..100,000];</br>
each element of array A is an integer within the range [−10,000..10,000].
