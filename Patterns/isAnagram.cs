//take the inputs and sort them, if the stings match when sorted => true
//frequency counter 'a' == 97 ascii and ascii values are subtracted to know the correct
//location the tally the seen letters
// o(n) o(1)
// orderby is sorting => o(nlogn)
public class Solution4
{
   public bool IsAnagram(string s, string t)
    {

        if (s.Length != t.Length) return false;

        var counts = new int[26];
        foreach (char c in s) counts[c - 'a']++;
        foreach (char c in t) counts[c - 'a']--;

        return counts.All(x => x == 0);


    }

}