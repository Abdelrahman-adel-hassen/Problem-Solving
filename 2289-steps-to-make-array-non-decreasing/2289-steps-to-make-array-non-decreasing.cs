public class Solution {
    public int TotalSteps(int[] nums)
{
    int ans = 0;
    var stack = new Stack<int>();
    var dp = new int[nums.Length];
    for (int i = nums.Length - 1; i >= 0; i--)
    {
        while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
        {
            dp[i] = Math.Max(++dp[i], dp[stack.Peek()]);
            stack.Pop();
        }

        ans = Math.Max(ans, dp[i]);
        stack.Push(i);
    }
    return ans;
}
}