public class Solution {
    public int MinPartitions(string n) {
        int minimumNumberOfDeciBinary=0;
        for(int i=0;i<n.Length;i++){
            minimumNumberOfDeciBinary=Math.Max(minimumNumberOfDeciBinary,n[i]-'0');
        }
        return minimumNumberOfDeciBinary;
    }
}