public class Solution {
    public bool IsItPossible(string word1, string word2)
{
        
    if(word1 == word2)
        return true;
    var words1 = new int[26];
    var words2 = new int[26];
    foreach (var ch in word1)
        words1[ch - 'a']++;
    foreach (var ch in word2)
        words2[ch - 'a']++;
    int distinctOfWord1 = GetDistinctCharacters(words1);
    int distinctOfWord2 = GetDistinctCharacters(words2);
    if (Math.Abs(distinctOfWord1 - distinctOfWord2) > 2)
        return false;

    for (int i = 0; i < 26; i++)
    {
        if (words1[i] == 0)
            continue;

        for (int j = 0; j < 26; j++)
        {
            if (words2[j] == 0)
                  continue;
              int newDistinctWord1 = distinctOfWord1;
              if (i != j)
              {
                  if (words1[i] - 1 == 0)
                      newDistinctWord1--;
                  if (words1[j] + 1 == 1)
                      newDistinctWord1++;
              }

              int newDistinctWord2 = distinctOfWord2;
              if (i != j)
              {
                  if (words2[j] - 1 == 0)
                      newDistinctWord2--;
                  if (words2[i] + 1 == 1)
                      newDistinctWord2++;
              }
            if (newDistinctWord1 != 0 && newDistinctWord2 == newDistinctWord1)
                return true;
        }
    }
    return false;
}
private int GetDistinctCharacters(int[] words)
{
    return words.Count(x => x > 0);
}
 
}