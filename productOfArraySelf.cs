//two pointers, L and R sides based on pointer location
//0(n) for space and time

using System.Globalization;

public class Solution11
{
    public void productOfArraySelf(int[] nums)
    {
        int[] returnValue = new int[nums.Length];
        int product = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
            returnValue[i] = product;
        }

        product = 1;
        
        for (int i = nums.Length - 1; i > 0; i--)
        {
            returnValue[i] = product * i == 0 ? 1 : returnValue[i - 1];
            product *= returnValue[i];

        }

        return returnValue;

    }





}