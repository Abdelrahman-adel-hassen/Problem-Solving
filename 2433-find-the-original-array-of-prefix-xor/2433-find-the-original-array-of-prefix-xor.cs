public class Solution {
    public int[] FindArray(int[] pref) {
        int num=0;
        return pref.Select(p=>{
            var tempNum=p^num;num=p;
            return tempNum;
        }).ToArray();
    }
}