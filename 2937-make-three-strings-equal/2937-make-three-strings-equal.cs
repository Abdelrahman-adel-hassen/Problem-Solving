public class Solution {
    public int FindMinimumOperations(string s1, string s2, string s3) {
        int n1=s1.Length,n2=s2.Length,n3=s3.Length;
        int minSize=Math.Min(Math.Min(n1,n2),n3);
        int ans=0;
        while(minSize>=0){
            if(s1==s2&&s2==s3){
                return ans;
            }
            while(n1>minSize){
                n1--;
                s1=s1.Remove(s1.Length - 1);
                ans++;
            }
            while(n2>minSize){
                n2--;
                s2=s2.Remove(s2.Length - 1);
                ans++;
            }
            while(n3>minSize){
                n3--;
                s3=s3.Remove(s3.Length - 1);
                ans++;
            }
            minSize--;
        }
        return minSize<=0?-1:ans;
    }
}