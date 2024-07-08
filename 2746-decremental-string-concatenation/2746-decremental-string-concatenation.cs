public class Solution {
    public int Solve(int i, char letterOne, char letterTwo, string[] words, int[,,] dp)
{
    int result = dp[i, letterOne - 'a', letterTwo - 'a'];
    if (i == words.Length)
        return dp[i, letterOne - 'a', letterTwo - 'a']=0;
    if (result != -1)
        return result;
   result = Solve(i + 1, letterOne, words[i].Last(), words, dp) + (letterTwo == words[i].First() ? 1 : 0);
   result = Math.Max(result, Solve(i + 1, words[i].First(), letterTwo, words, dp) + (letterOne == words[i].Last() ? 1 : 0));
   return dp[i, letterOne - 'a', letterTwo - 'a'] = result;
}
public int MinimizeConcatenatedLength(string[] words)
{
    int[,,] dp = new int[1005, 26, 26];
    for (int i = 0; i < dp.GetLength(0); i++)
    {
        for (int j = 0; j < dp.GetLength(1); j++)
        {
            for (int k = 0; k < dp.GetLength(2); k++)
            {
                dp[i, j, k] = -1;
            }
        }
    }
    var result = Solve(1, words[0].First(), words[0].Last(), words, dp);
    Console.WriteLine(result);
    return words.Sum(word => word.Length) - result;
}
}