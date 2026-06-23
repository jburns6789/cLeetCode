// 2 pointers
// two int arrays sorted in place non decreasing order, sort into a single array sorted in non decreasing order
// final array not returned but sorted in num1 array**
// don't include the zeros ---> iterate from right to left to handle the the zeros
// usig the pointer index location to calcualte the where the numbers are going to end up
// comparing the the indexs from each array to sort in the final array


public class Solution8
{
    public void Merge(int[] nums1, int m, int [] nums2, int n)
    {
        int returnArrayCounter =  nums1.Length - 1;
        int num1Counter = m - 1;
        int num2Counter = n - 1;

        while (num1Counter >= 0 || num2Counter >= 0)
        {
            if (num1Counter >= 0 && num2Counter >= 0)
            {
                if (nums1[num1Counter] > nums2[num2Counter])
                {
                    nums1[returnArrayCounter] = nums1[num1Counter];
                    num1Counter--;
                }

                else
                {
                    nums1[returnArrayCounter] = nums2[num2Counter];
                    num1Counter--;
                }
            }
            else if (num1Counter >= 0)
            {
                nums1[returnArrayCounter] = nums1[num1Counter];
                num1Counter--;  
                
            }
            else
            {
                nums1[returnArrayCounter] = nums2[num2Counter];
                num2Counter--;
            }

            returnArrayCounter--;

        }
        



    }
}