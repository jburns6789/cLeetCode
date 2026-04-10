//sliding window w/ hashset
// two pointers create a slidng window, left and right
//if there are repeating characters the window exapnds and contracts based of duplicate
//patterns
//o(n) each character is only processed once

public class Solution6
{
    public int LengthOfLongestSubstring(string s)
    {

        int n = s.Length;
        int maxLength = 0;
        int left = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int right = 0; right < n; right++)
        { 
            char currentChar = s[right];

            //if repeating char is found, move left pointer
            if (charIndexMap.ContainsKey(currentChar))
            {
                left = Math.Max(left, charIndexMap[currentChar] + 1);

            }

            //Update the last seen index of the current character
            charIndexMap[currentChar] = right;

            //calcuate the window size and update the max length
            maxLength = Math.Max(maxLength, right - left + 1);

        }

        return maxLength;



    }

}


// find the length of the longest substring w/o duplicate characters
// A subsequence is a subset of a larger set where relative order is preserved, 

//int left = 0;
//int right = 0;
//int maxLength = 0;
//HashSet<char> charSet = new();

//while (right < s.length )
    //if(!charSet.Contains(s.right))
        //charSet.Add(s.right)
        //right++;
        //maxLength = Math.Max(maxLength, right - left);   <----- very common way to find max

    //else
        //charSet.Remove(s.left);
        //left++;

//less efficent solution