public class Solution {
    public string MinimizeStringValue(string s) {
    var characters = new int[26];
    foreach (char ch in s)
    {
        if (ch != '?')
            characters[ch - 'a']++;
    }

    int index = 0;
    List<char> charchatersTemp = new();
    StringBuilder anwer = new();
    foreach (char ch in s)
    {
        if (ch == '?')
        {
            index = 0;
            for (int i = 1; i < 26; i++)
            {
                if (characters[index] > characters[i])
                    index = i;
            }
            characters[index]++; ;
            charchatersTemp.Add((char)(index + 'a'));

        }
    }
    index = 0;
    charchatersTemp = charchatersTemp.Order().ToList();
    foreach (char ch in s)
    {
        if (ch == '?')
            anwer.Append(charchatersTemp[index++]);
        else
            anwer.Append(ch);

    }
    return anwer.ToString();
    }
}