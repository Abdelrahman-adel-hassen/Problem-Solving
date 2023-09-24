public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        int x = -1;
        int y = -1;
        int ans=int.MaxValue;
        for (int i = 0; i < wordsDict.Length; i++)
        {
            if (wordsDict[i] == word1)
                x = i;
            if (wordsDict[i] == word2)
                y = i;
            if(x!=-1&&y!=-1)
                 ans=Math.Min(ans,Math.Abs(x - y));
        }

        return ans;
    }
}