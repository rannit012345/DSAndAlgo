using System.Collections.Generic;

namespace DSAndAlgo.Recursion
{
    class JosephusProblem
    {
        /// <summary>
        /// I/P - n = 5 (0, 1, 2, 3, 4) and k = 2 | O/P ans = 2
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public int Survivor(int n, int k)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++) 
            {
                list.Add(i);
            }

            k = k - 1;
            int ans = -1;
            int index = 0;

            Solve(list, k, index, ref ans);

            return ans;
        }

        private void Solve(List<int> list, int k, int index, ref int ans)
        {
            if (list.Count == 1)
            {
                ans = list[0];
                return;
            }

            index = (index + k) % list.Count;
            list.RemoveAt(index);

            Solve(list, k, index, ref ans);
        }
    }
}
