public class Solution {
    public int MinLengthAfterRemovals(IList<int> nums) {
        int removeNumbers = 0;
        int l = nums.Count  / 2 - 1;

        int r = nums.Count - 1;
        while (l >= 0)
        {
            if (nums[l] != nums[r])
                removeNumbers += 2;
            l--;
            r--;
        }
        return nums.Count - removeNumbers;
       
    }
}