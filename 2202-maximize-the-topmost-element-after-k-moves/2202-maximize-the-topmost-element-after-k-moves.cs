public class Solution {
    public int MaximumTop(int[] nums, int k) {
        if(nums.Length==1)
            return k%2==1?-1:nums[0];
        if(k<=1)
            return nums[k];
        int mx=0;
        if(k<nums.Length)
            mx=nums[k];
        k=Math.Min(k-1,nums.Length);
        for(int i=0;i<k;i++){
            mx=Math.Max(mx,nums[i]);
        }
        return mx;
    }
}