
public class Solution
{

    public string LicenseKeyFormatting(string s, int k)
    {
        StringBuilder stringBuilder = new StringBuilder();
        var numberOfCharachters = GetNumberOfCharachtersInWord(ref s);
        var firstGroup = numberOfCharachters % k;
        Console.WriteLine(firstGroup);
        int index = 0;
        var currentOfK = 0;
        bool isFirstGroupExist = firstGroup > 0;
        int n = s.Length;
        s = s.ToUpper();
        while (firstGroup > 0)
        {
            if (s[index] != '-')
            {
                stringBuilder.Append(s[index]);
                firstGroup--;
            }
            index++;
        }
        while (index < n)
        {
            if (s[index] != '-')
            {
                if (isFirstGroupExist || currentOfK == k)
                {
                    isFirstGroupExist = false;
                    currentOfK = 0;
                    stringBuilder.Append('-');
                }
                currentOfK++;
                stringBuilder.Append(s[index]);

            }
            index++;
        }
        return stringBuilder.ToString();
    }

    private int GetNumberOfCharachtersInWord(ref string s)
    {
        var num = 0;
        foreach (var character in s)
        {
            if (character != '-')
                num++;
        }

        return num;
    }
}