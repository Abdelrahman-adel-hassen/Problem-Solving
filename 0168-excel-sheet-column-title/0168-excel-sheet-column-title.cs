public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string ans="";
        while(columnNumber>0){
            int num=columnNumber%26;
            if(num==0)
                num=26;            
            ans=(char)(num-1+'A')+ans;
            columnNumber=(columnNumber-1)/26;
        }
        return ans;
    }
}