public class Solution {
    int[] dp = null;
    public int MinimumNumbers(int num, int k)
    {
        if (num == 0)
            return 0;
        if(k==0)
            return num%10==0?1:-1;
        dp = new int[num + 1];
        for (int i = 0; i <= num; i++)
            dp[i] = -1;
        int result = Solve(num, k);
        return result >= 5000 ? -1 : result;
    }

    int Solve(int num, int k)
    {
        if (num == 0)
            return 0;
        
        int result = 5000;
        if (dp[num] != -1)
            return dp[num];
        for (int i = 0; i <= num / 10; i++)
        {
            int sum = (i * 10 + k);
            if (sum > num)
                break;
            result = Math.Min(result, Solve(num - sum, k) + 1);
        }
        return dp[num] = result;
    }
}