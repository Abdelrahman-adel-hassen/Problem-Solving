public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int maxSum=-1000000;
        int maxCurrntSum=0;
        int numberOfElements=0;
        for(int i=0;i<nums.Count();i++){
            maxCurrntSum+=nums[i];
           if(i+1>=k){
               maxSum=Math.Max(maxSum,maxCurrntSum);
               maxCurrntSum-=nums[i-k+1];
           }   
        }
        return (double)maxSum/k;
    }
}