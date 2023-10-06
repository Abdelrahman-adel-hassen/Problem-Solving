public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        
        Array.Reverse(words);
        
        return string.Join(" ", words);
    }
}