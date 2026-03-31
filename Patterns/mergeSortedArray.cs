// 3 pointers

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