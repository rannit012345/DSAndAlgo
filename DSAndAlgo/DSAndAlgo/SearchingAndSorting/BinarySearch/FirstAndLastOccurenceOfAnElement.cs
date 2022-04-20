
namespace DSAndAlgo.SearchingAndSorting.BinarySearch
{
    /// <summary>
    /// First Occurence
    /// Last Occurence
    /// Count Occurence
    /// </summary>
    class FirstAndLastOccurenceOfAnElement
    {
        public int FirstOccurence(int[] arr, int ele)
        {
            int start = 0;
            int end = arr.Length - 1;
            int res = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (ele == arr[mid])
                {
                    res = mid;
                    end = mid - 1;
                }
                else if (ele < arr[mid]) end = mid - 1;
                else start = mid + 1;
            }
            return res;
        }

        public int LastOccurence(int[] arr, int ele)
        {
            int start = 0;
            int end = arr.Length - 1;
            int res = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (ele == arr[mid])
                {
                    res = mid;
                    start = mid + 1;
                }
                else if (ele < arr[mid]) end = mid - 1;
                else start = mid + 1;
            }
            return res;
        }

        public int CountOccurence(int[] arr, int ele)
        {
            int firstOccurence = FirstOccurence(arr, ele);
            int lastOccurence = LastOccurence(arr, ele);

            return lastOccurence - firstOccurence + 1 ;
        }
    }

    /* Test code
        FirstAndLastOccurenceOfAnElement bs = new FirstAndLastOccurenceOfAnElement();
        Console.WriteLine(bs.FirstOccurence(new int[] { 2, 4, 10, 10, 10, 18, 20 }, 10));
        Console.WriteLine(bs.LastOccurence(new int[] { 2, 4, 10, 10, 10, 18, 20 }, 10));
        Console.WriteLine(bs.CountOccurence(new int[] { 2, 4, 10, 10, 10, 18, 20 }, 10));
     */
}
