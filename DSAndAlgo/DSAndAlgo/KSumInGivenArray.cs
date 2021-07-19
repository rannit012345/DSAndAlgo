using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    class KSumInGivenArray
    {
        public static List<IList<int>> TwoSum(int[] nums, int left, int right, int target)
        {
            var twosumList = new List<IList<int>>();
            while (left < right)
            {
                var sum = nums[left] + nums[right];
                if (sum < target)
                    left++;
                else if (sum > target)
                    right--;
                else
                {
                    var temp = new List<int> { nums[left], nums[right] };
                    twosumList.Add(temp);

                    //Handle duplicate combinations
                    //Remember array is sorted
                    //while (left < right && nums[left] == nums[left + 1])
                    //    left++;

                    //Handle duplicate combinations
                    //Remember array is sorted
                    //while (left < right && nums[right] == nums[right - 1])
                    //    right--;

                    left++;
                    right--;
                }
            }

            return twosumList;
        }
    }
}
