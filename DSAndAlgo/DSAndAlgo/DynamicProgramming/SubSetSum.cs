using System;
using System.Collections.Generic;

namespace DSAndAlgo.DynamicProgramming
{
    class SubSetSum
    {

		#region Is Subset with a given sum present or not - using Recursion

		/// <summary>
		/// IsSubSetSumPresent 
		/// </summary>
		/// <returns></returns>
		public bool IsSubSetSumPresent()
        {
			return true;
			
        }


		#endregion


		#region Print all subsets with a given sum - using Recursion

		/// <summary>
		/// C# program to print all subsets with given sum
		/// i/p : {2, 5, 8, 4, 6, 11}, sum = 13
		/// o/p : 5 8, 2 11, 2 5 6
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="n"></param>
		/// <param name="v"> he vector v stores current subset. </param>
		/// <param name="sum"></param>
		static void PrintAllSubsetsRec(int[] arr, int n, List<int> v, int sum)
		{
			// If remaining sum is 0, then print all elements of current subset.
			if (sum == 0)
			{
				for (int i = 0; i < v.Count; i++)
					Console.Write(v[i] + " ");
				Console.WriteLine();
				return;
			}

			// If no remaining elements,
			if (n == 0)
				return;

			// We consider two cases for every element.
			// a) We do not include last element.
			// b) We include last element in current subset.
			PrintAllSubsetsRec(arr, n - 1, v, sum);
			List<int> v1 = new List<int>(v);
			v1.Add(arr[n - 1]);
			PrintAllSubsetsRec(arr, n - 1, v1, sum - arr[n - 1]);
		}

		/// <summary>
		/// Wrapper over printAllSubsetsRec()
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="n"></param>
		/// <param name="sum"></param>
		public static void PrintAllSubsets(int[] arr, int n, int sum)
		{
			List<int> v = new List<int>();
			PrintAllSubsetsRec(arr, n, v, sum);
		}

		#endregion
	}
}

