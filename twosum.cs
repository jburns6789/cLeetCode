public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> myComp = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){//iterate through nums find the compliment
            int complement = target - nums[i];

            if (myComp.ContainsKey(complement)){
                return new int[]{myComp[complement], i}; // returns true or false, check to ensure duplicates dont exist
            }

            if (!myComp.ContainsKey(nums[i])){// if there is a match indicies retured
                myComp.Add(nums[i], i);
            }


        }

        return new int[0];

    }
}