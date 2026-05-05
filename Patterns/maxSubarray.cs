//Given an integer array nums, find the subarray with the largest sum, and return its sum.
//Subarray A subarray is a contiguous non-empty sequence of elements within an array.
//[-2,1,-3,4,-1,2,1,-5,4]

//kadanes algorithm, pointers

using System.Diagnostics.CodeAnalysis;

public class Solution14
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            maxSum = Math.Max(maxSum, currentSum);

        }
        return maxSum;
    }
}