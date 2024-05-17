public class Solution {
    public long MaximumTripletValue(int[] nums) {
        int n=nums.Count();
        long mx=nums[n-1];
        long ans=0;
        for(int i=0;i<n-2;i++){
            mx=nums[n-1];
            for(int j=n-2;j>i;j--){     
                ans=Math.Max((nums[i]-nums[j])*mx,ans);
                mx=Math.Max(mx,nums[j]);
            }
        }
        return ans;
        
    }
}