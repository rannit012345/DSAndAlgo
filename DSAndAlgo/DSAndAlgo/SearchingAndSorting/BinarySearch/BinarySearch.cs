
namespace DSAndAlgo.SearchingAndSorting.BinarySearch
{
    class BinarySearch
    {
        /// <summary>
        /// Searching an element in a sorted array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="ele"></param>
        public int Search(int[] arr, int ele)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (ele == arr[mid]) return mid;
                else if (ele < arr[mid]) end = mid - 1;
                else start = mid + 1;
                
            }

            return -1;
        }

        /// <summary>
        /// Searching an element in a sorted array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="ele"></param>
        /// <returns></returns>
        public int SearchSortedArrayInReverseOrder(int[] arr, int ele)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (ele == arr[mid]) return mid;
                else if (ele < arr[mid]) start = mid + 1;
                else end = mid - 1;
            }

            return -1;
        }


        /// <summary>
        /// Searching an element in a sorted array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="ele"></param>
        /// <returns></returns>
        public int SearchSortedArrayInUnknownOrder(int[] arr, int ele)
        {
            int size = arr.Length;

            if (size == 0) return -1;
            else if (arr[0] < arr[1]) { return Search(arr, ele); }
            else if (arr[0] > arr[1]) { return SearchSortedArrayInReverseOrder(arr, ele); }

            return -1;
        }
    }
}
