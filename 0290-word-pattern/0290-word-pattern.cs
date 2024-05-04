public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words=s.Split(' ').ToList();
        var letters=pattern;
        if(letters.Count()!=words.Count())
            return false;
        
        var LettersMapping=new Dictionary<char,int>();
        var WordsMapping=new Dictionary<string,int>();
        for(int i=0;i<letters.Length;i++){
            if(!LettersMapping.ContainsKey(letters[i]))
                LettersMapping[letters[i]]=i;
            
            if(!WordsMapping.ContainsKey(words[i]))
                 WordsMapping[words[i]]=i;
            if(LettersMapping[letters[i]]!=WordsMapping[words[i]])
                return false;
        }
        return true;
        
    }
}