
namespace DSAndAlgo.SearchingAndSorting.BinarySearch
{
    class FindNumberOfTimesASortedArrayIsRotated
    {
        /// <summary>
        /// Array i/p = 6, 8, 11, 12, 15, 18, 2, 5
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="ele"></param>
        /// <returns></returns>
        public int RotationCount(int[] arr)
        {
            int length = arr.Length; 
            int start = 0;
            int end = length - 1;

            while (start <= end )
            {
                int mid = start + (end - start) / 2;
                int next = (mid + 1) % length;
                int prev = (mid + length - 1) % length;

                if (arr[mid] <= arr[next] && arr[mid] <= arr[prev]) return (length - 1) - mid + 1;  //mid will be the minimum element
                else if (arr[mid] >= arr[start]) start = mid + 1; 
                else if (arr[mid] <= arr[end]) end = mid - 1;
            }

            return -1;
        }
    }
}
