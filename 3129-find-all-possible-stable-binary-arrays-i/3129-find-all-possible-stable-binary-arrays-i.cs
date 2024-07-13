public class Solution {
    const int mod = 1000000000 + 7;

    public int NumberOfStableArrays(int zero, int one, int limit)
{
    var length = 200;
    var dp = new int[3, limit+1, zero+1, one + 1];
    for (int i = 0; i <= 2; i++)
        for (int l = 0; l <= limit; l++)
            for (int z = 0; z <= zero; z++)
                 for (int o = 0; o <= one; o++)
                    dp[i,l,z,o] = -1;

    var result = Solve(2, zero, one, limit,limit, dp);
    return result;
}
public int Solve(int prev, int zero, int one, int limit, int lim, int[,,,] dp)
{
    if (zero < 0 || one < 0)
        return 0;
    if (dp[prev, limit, zero, one] != -1)
        return dp[prev, limit, zero, one];
    if (limit == 0)
        return dp[prev, limit, zero, one] = 0;
    if (zero == 0 && one == 0)
        return dp[prev, limit, zero, one] = 1;
    return dp[prev, limit, zero, one] = (Solve(0, zero - 1, one, prev == 0 ? limit - 1 : lim, lim, dp)% mod + Solve(1, zero, one - 1, prev == 1 ? limit - 1 : lim, lim, dp)% mod)% mod;
}
}