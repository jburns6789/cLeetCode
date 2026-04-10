//two pointers, temp is needed beacuse the valuse would be overwritten during the swap
//on o1

public class Solution6
{
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;

        }
        

    }
}