public class Solution {
    List<string> result = new();
    int[,] dp = null;

    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
    {
        dp = new int[words.Length + 1, words.Length + 1];
        for (int j = 0; j <= groups.Length; j++)
        {
            for (int k = 0; k <= groups.Length; k++)
            {
                dp[j, k] = -1;
            }
        }

        int res = Solve(0, words.Length, words, groups);
        Console.WriteLine(res);
        GetLongestSub(0, words.Length, res, words, groups);
        return result;
    }
    public int Solve(int i, int prevIndex, string[] words, int[] groups)
    {
        if (i == words.Length)
            return dp[i, prevIndex] = 0;
        if (dp[i, prevIndex] != -1)
            return dp[i, prevIndex];
        int result = 0;
        if (prevIndex == groups.Length || (groups[i] != groups[prevIndex] && IsHammingDistance(words[i], words[prevIndex])))
            result = Solve(i + 1, i, words, groups) + 1;

        return dp[i, prevIndex] = Math.Max(result, Solve(i + 1, prevIndex, words, groups));
    }

    public void GetLongestSub(int i, int prevIndex, int longestSub, string[] words, int[] groups)
    {
        if (i == words.Length)
            return;
        if (dp[i + 1, i] == longestSub - 1 && (prevIndex == groups.Length || (groups[i] != groups[prevIndex] && IsHammingDistance(words[i], words[prevIndex]))))
        {
            result.Add(words[i]);
            GetLongestSub(i + 1, i, longestSub - 1, words, groups);
        }
        else
            GetLongestSub(i + 1, prevIndex, longestSub, words, groups);

    }

    public bool IsHammingDistance(string word1, string word2)
    {
        bool diff = false;
        if (word1.Length != word2.Length)
            return false;
        for (int i = 0; i < word1.Length; i++)
        {
            if (word1[i] != word2[i])
            {
                if (diff)
                    return false;
                diff = true;
            }

        }
        return true;
    }

}