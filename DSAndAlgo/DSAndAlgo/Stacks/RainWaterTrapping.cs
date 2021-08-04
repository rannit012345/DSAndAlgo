using System;

namespace DSAndAlgo.Stacks
{
    /// <summary>
    /// RainWaterTrapping is different from Histogram
    /// </summary>
    class RainWaterTrapping
    {
        /// <summary>
        /// I/P - 3, 0, 0, 2, 0, 4 | O/P - 10
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int UnitOfWater(int[] arr)
        {
            int size = arr.Length;

            int[] mxl = new int[size];
            int[] mxr = new int[size];

            mxl[0] = arr[0];
            for (int i = 1; i < size; i++)
            {
                mxl[i] = Math.Max(mxl[i - 1], arr[i]);
            }

            mxr[mxr.Length - 1] = arr[size - 1];
            for (int i = size - 2; i >= 0; i--)
            {
                mxr[i] = Math.Max(mxr[i + 1], arr[i]);
            }

            int[] water = new int[size];
            for (int i = 0; i < size; i++)
            {
                water[i] = Math.Min(mxl[i], mxr[i]) - arr[i];
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + water[i];
            }

            Console.WriteLine("Units of water {0}", sum);
            return sum;
        }
    }
}
