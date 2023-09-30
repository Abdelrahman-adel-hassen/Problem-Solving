public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int len=nums.Length;
        var ans=new int[len];
        for(int i=0;i<len/2;i++){
           ans[i*2]=nums[i];
           ans[i*2+1]=nums[i+n];
        }
        return ans;
    }
}