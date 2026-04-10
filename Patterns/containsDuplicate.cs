//want to use hashset for space and time complexity, specific for this use case
//concept is to check what ahs been seen and return the duplicate and stop iterating

using System.Security.Cryptography.X509Certificates;

public class Solution3
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hasvalues = new HashSet<int>();

        foreach(var item in nums)
        {
            if (hasvalues.Contains(item))
                return true;
            hasvalues.Add(item);
        }

        return false;
    }

}