public class Solution {
    public bool CanBeEqual(string s1, string s2) {
        s1=SortEvenOddIndicesUsingLinq(s1);
        s2=SortEvenOddIndicesUsingLinq(s2);
        return s1==s2;
    }
    private string SortEvenOddIndicesUsingLinq(string input)
    {
        var evenChars = input.Where((c, i) => i % 2 == 0).OrderBy(c => c).ToArray();
        var oddChars = input.Where((c, i) => i % 2 != 0).OrderBy(c => c).ToArray();

        return new string(input
            .Select((c, i) => i % 2 == 0 ? evenChars[i / 2] : oddChars[i / 2])
            .ToArray());
    }
}