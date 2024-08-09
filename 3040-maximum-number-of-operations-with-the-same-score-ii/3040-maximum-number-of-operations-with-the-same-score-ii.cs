public class Solution {
    public int MaxOperations(int[] nums)
    {
        int[,] dp = new int[nums.Length + 1, nums.Length + 1];
        return Solve(nums, 0, nums.Length - 1, -1, dp);
    }
    public int Solve(int[] nums, int st, int en, int score, int[,] dp)
    {
       if (en - st <= 0)
           return 0;
       if (dp[st, en] != -0)
           return dp[st, en];
       int maxOperation = dp[st, en];
       if (score == -1 || score == nums[st] + nums[st + 1])
           maxOperation = Solve(nums, st + 2, en, nums[st] + nums[st + 1], dp) + 1;
       if (score == -1 || score == nums[en] + nums[en - 1])
           maxOperation = Math.Max(maxOperation, Solve(nums, st, en - 2, nums[en] + nums[en - 1], dp) + 1);
       if (score == -1 || score == nums[st] + nums[en])
           maxOperation =  Math.Max(maxOperation, Solve(nums, st + 1, en - 1, nums[st] + nums[en], dp) + 1);
       return dp[st, en] = maxOperation;
    }
}