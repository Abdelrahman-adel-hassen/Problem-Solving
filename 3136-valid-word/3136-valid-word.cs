public class Solution {
    public bool IsValid(string word) {
        if(word.Length < 3) 
            return false;
        var numStr = "0123456789";
        var consonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ"; 
        var vowel = "aeiouAEIOU";
        var notUse = "@#$";
        var hasVowel = false;
        var hasConsonant = false;

        foreach(var ch in word){
            if(notUse.Contains(ch))
                return false;
            else if(consonant.Contains(ch))
                hasConsonant = true;
            else if(vowel.Contains(ch))
                hasVowel = true;
        }

        return hasConsonant && hasVowel;
    }
}