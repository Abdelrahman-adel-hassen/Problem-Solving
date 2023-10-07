public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n=nums.Length;
        int sum=0,l=0;
        int ans=n+1;
        for(int i=0;i<n;i++){
            sum+=nums[i];
            while(sum>=target){
                ans=Math.Min(ans,i-l+1);
                sum-=nums[l++];
            }  
        }
        return ans==n+1?0:ans;
    }
}