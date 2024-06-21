public class Solution {
    public bool IsGood(int[] nums) {
       Array.Sort(nums);

        if (nums[nums.Length - 1] != nums.Length - 1 || 
        nums[nums.Length - 1] != nums[nums.Length - 2])
            return false;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] != i+1)
                return false;
        }

        return true;
    }
}