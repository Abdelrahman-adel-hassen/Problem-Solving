public class Solution {
    public bool BuddyStrings(string s, string goal) {
        //if it equals an no two letters exists return false
        //there more than two differnece
        var sLength=s.Length;
        if(sLength!=goal.Length)
            return false;
        if(sLength==1)
            return false;
        var lettersFrequency=new bool[30];
        int letter1=-1,letter2=-1;
        bool sameLetterExist=false;
        for(int i=0;i<sLength;i++){
            if(lettersFrequency[s[i]-'a'])
                sameLetterExist=true;
             lettersFrequency[s[i]-'a']=true;
            if(s[i]!=goal[i]){
                if(letter1==-1)
                    letter1=i;
                else if(letter2==-1)
                    letter2=i;
                else
                    return false;
            }
        }
        if(letter1==-1)
            return sameLetterExist;
        if(letter2==-1)
            return false;
        return s[letter2]==goal[letter1]&&s[letter1]==goal[letter2];
    }
}