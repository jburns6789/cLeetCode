// convert upper to lower char and remove non alpha numeric 
// naive, create new string reverse and compare 0(2n) 0(n)
//optimal 2 pointers ignore white space and non alpha numeric chars

// time O(n) space O(1) dependant and length of string and no new space created

public class Solution5
{
    public bool IsPalindrone(string s)
    {
        if (s == null || s.Length < 2)
        {
            return true;
        }
        else
        {
            int startIndex = 0;
            int endIndex = s.Length -1;
            while (startIndex < endIndex)
            {
                if (!char.IsLetterOrDigit(s[startIndex]))
                {
                    startIndex++;
                }
                else if{
                    (!char.IsLetterOrDigit(s[endIndex])){
                        endIndex--;
                    }
                }
                else
                {
                    if (char.ToUpper(s[startIndex]) != char.ToUpper(s[endIndex]))
                    {
                        return false;
                    }

                    startIndex++;
                    endIndex--;
                }
            }
        }

        return true;

    }
}