public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
            var ans = new List<int>();
        int cnt = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1] + 1)
                ++cnt;
            else
                cnt = 1;
            if (i + 1 >= k)
                ans.Add(cnt >= k ? nums[i] : -1);
        }
        return ans.ToArray();
    }
}