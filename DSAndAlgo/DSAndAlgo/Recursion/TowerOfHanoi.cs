using System;

namespace DSAndAlgo.Recursion
{
    class TowerOfHanoi
    {
        /// <summary>
        ///  TowerOfHanoi toh = new TowerOfHanoi();
        //   int count = 0;
        //   toh.PrintSteps(3, 1, 3, 2, ref count);
        /// </summary>
        /// <param name="numberOfDisk"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="helper"></param>
        public int PrintSteps(int numberOfDisk, int source, int destination, int helper, ref int count)
        {
            if (numberOfDisk == 1)
            {
                Console.WriteLine("Moved disk {0} from {1} to {2}", numberOfDisk, source, destination);
                count++;
                return count;
            }

            PrintSteps(numberOfDisk - 1, source, helper, destination, ref count);

            Console.WriteLine("Moved disk {0} from {1} to {2}", numberOfDisk, source, destination);
            count++;

            PrintSteps(numberOfDisk - 1, helper, destination, source, ref count);

            return count;

        }
    }
}
