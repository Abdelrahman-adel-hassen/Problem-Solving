public class Solution {
    public bool CanJump(int[] nums) {
          int mxJump=0,mxValue=0,n=nums.Length;
           for(int i=0;i<n-1;i++){
                if(i==mxValue&&nums[i]==0)
                    return false;   
                mxValue=Math.Max(mxValue,i+nums[i]);
            }
            return true;
    }
}