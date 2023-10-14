public class Solution {
    public int Jump(int[] nums) {
          int mxJump=0,prevMxValue=0,n=nums.Length;
          if(n<=1)
              return 0;
          int currMxValue=Math.Min(n-1,nums[0]);
           for(int i=1;i<n;i++){
               int mnValue=Math.Min(i+nums[i],n-1);
                prevMxValue=Math.Max(prevMxValue,mnValue);
                if(i==currMxValue){
                    mxJump++;
                    currMxValue=prevMxValue;
                }
            }
            return mxJump;
    }
}
/*
    mxJump=0,mxValue=0,currIndex=0;
   2,3,1,1,4
    mxJump=1,mxValue=4,i=1
   2,3,0,1,4
    mxJump=1,mxValue=4,i=1
    3,0,1,4
    mxJump=1,mxValue=4,i=1
     1,4,0,1,4
    mxJump=1,mxValue=4,i=1
    1,1,1,1,1
    mxJump=1,mxValue=4,i=1
   for(i){
        if(i>=n-1){
            mxJump++;
            break;
        }
        if(i==mxValue)
            mxJump++;
        mxValue=max(mxValue,i+nums[i]);
    }
    return mxJump;

*/