public class Solution {
    public int LengthOfLastWord(string s) {
        int length=0;
        s=s.Trim();
        int n=s.Length;
        for(int i=n-1;i>=0;i--){
            
            if(s[i]==' ')
                break;
            else
                length++;
        }
        return length;
    }
}