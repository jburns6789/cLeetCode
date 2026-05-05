//two pointers, inplace is optimal on and o1
//naive create new array put zeros in front 

//counts the number of zeros and them puts that many at the end of the array
using System.Security.AccessControl;

public class Solution10
{
    public void moveZeros(int[] nums)
    {
        int j = 0;

        for ( int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[j] = nums[i];
                j++;

            }
            
        }

        for (int i = j; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

    }

}