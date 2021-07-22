using System;

namespace DSAndAlgo.Recursion
{
    /// <summary>
    /// 0 --> 0,1 and 1 --> 1,0 and if N = 1, K = 1, return 0
    /// Using above condition, below is the grammar
    ///         k = 1 k = 2 k = 3 k = 4 K = 5 k = 6 k = 7 k = 8 
    /// N = 1   0
    /// N = 2   0      1      
    /// N = 3   0      1     1     0
    /// N = 4   0      1     1     0     1      0     0     1
    /// Print the value present at (N, K) in grammar
    /// </summary>
    class KthSymbolInGrammar
    {
        public int Solve(int N, int K)
        {
            //Corner case - For a particular N, K should be not greater than Math.Pow(2, N-1)
            if (K > (int)Math.Pow(2, N-1) || K < 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (N == 1 && K == 1)
            {
                return 0;
            }

            int mid = (int)Math.Pow(2, N-1) / 2;

            if (K <= mid)
            {
                return Solve(N - 1, K);
            }
            else
            {
                 int value = Solve(N - 1, K - mid);
                 return value == 0 ? 1 : 0;  //Have to check better way to complement
            }
        }
    }
}
