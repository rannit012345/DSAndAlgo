namespace DSAndAlgo.GeneralProblems
{
    class Palindrome
    {
        /// <summary>
        /// Test i/p - "abba", "1221", "naman", "12321", "aaaa", "a"  , "123421"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool CheckForPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
