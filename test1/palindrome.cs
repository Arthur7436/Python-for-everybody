using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1
{
    public class palindrome
    {
        public class Solution
        {

            public int GetLengthOfNum(string num)
            {
                int length = 0;

                foreach (char c in num)
                {
                    length++;
                };

                return length;
            }

            public bool IsPalindrome(int x)
            {
                //convert input to string
                //find the start and end value in terms of length
                //use the two pointer method to see if the numbers match
                //if numbers do not match return false
                //else continue drawing the pointers closer
                //return true

                string num = x.ToString();

                int start = 0;
                int end = GetLengthOfNum(num) - 1;

                while (start < end)
                {
                    if (num[start] != num[end])
                    {
                        return false;
                    }
                    else
                    {
                        start++;
                        end--;
                    }
                }

                return true;
            }
        }
    }
}