public class Solution {
    public long MaxStrength(int[] nums) {
        long ans = 1;
        int maxNegativeNumber=-10;
        int numZeros=0;
        bool isPositve=false;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                 ans*=nums[i];
                 if(ans>0||nums[i]>0)
                     isPositve=true;
            }
            if(nums[i]<0)
               maxNegativeNumber=Math.Max(maxNegativeNumber,nums[i]);
            if(nums[i]==0) 
                numZeros++;
               
        }
        if(isPositve)
            return  Math.Max(ans,ans/maxNegativeNumber);

        return numZeros>0?0:ans;
    }
}