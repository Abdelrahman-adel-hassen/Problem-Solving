public class Solution {
    public long MaximumTotalDamage(int[] power)
{
    long[] dp = new long[power.Length];
    for (int i = 0; i < power.Length; i++)
        dp[i] = dp[i] = -1;
    List<Tuple<int, int>> numbers = power
    .GroupBy(x => x)
    .Select(g => new Tuple<int, int>(g.Key, g.Count()))
    .OrderBy(g => g.Item1)
    .ToList();
    var result = Solve(0, dp, numbers);
    return result;
}
public long Solve(int i, long[] dp, List<Tuple<int, int>> numbers)
{
    if (i >= numbers.Count)
        return 0;
    if (dp[i] != -1)
        return dp[i];
    long result = 0;
    int nextIndex = i + 1 >= numbers.Count || numbers[i + 1].Item1 > numbers[i].Item1 + 2 ? 1 : 2;
    if (nextIndex == 2)
        nextIndex = i + 2 >= numbers.Count || numbers[i + 2].Item1 > numbers[i].Item1 + 2 ? 2 : 3;
    dp[i] = result = Solve(i + nextIndex, dp, numbers) + numbers[i].Item1 * (long)numbers[i].Item2;

    return dp[i] = Math.Max(result, Solve(i + 1, dp, numbers));
}
}