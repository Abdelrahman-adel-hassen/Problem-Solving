public class Solution {
    public bool IsFascinating(int n) {
        string num="";
        num+=n;
        num+=n*2;
        num+=n*3; 
        HashSet<char> map = new HashSet<char>();
        foreach(var ch in num){
            if(map.Contains(ch)||ch=='0'){
                return false;
            }
            map.Add(ch);
        }
        
        return map.Count == 9;
    }
}