public class Solution {
    public int MinimumSubarrayLength(int[] nums, int k) {
        if(k==0)
            return 1;
        int numbersWithORS=0;
        int CurrentSubIndex=0;
        int ans=51;
        var bitWiseNumberCount=new int[6];
        for(int i=0;i<nums.Count();i++){
            SetBitWiseNumberCount(bitWiseNumberCount,nums[i]);
            numbersWithORS=GetCurrentNumbersWithORS(bitWiseNumberCount);
        
            while(numbersWithORS>=k){
                ans=Math.Min(ans,i-CurrentSubIndex+1);
                UnSetBitWiseNumberCount(bitWiseNumberCount,nums[CurrentSubIndex]);
                CurrentSubIndex++;
                numbersWithORS=GetCurrentNumbersWithORS(bitWiseNumberCount);
            }
            
               
        }
        return ans==51?-1:ans;
    }
    private void SetBitWiseNumberCount(int[] bitWiseNumberCount,int num){
        int currentIndex=0;
        while(num>0){
            bitWiseNumberCount[currentIndex]+=(num&1)==1?1:0;
            num>>=1;
            currentIndex++;
        }
        
    }
    private void UnSetBitWiseNumberCount(int[] bitWiseNumberCount,int num){
        int currentIndex=0;
        while(num>0){
            bitWiseNumberCount[currentIndex]-=(num&1)==1?1:0;
            num>>=1;
             currentIndex++;
        }
    }
     private int GetCurrentNumbersWithORS(int[] bitWiseNumberCount){
         int numbersWithORS=0;
        for(int i=0;i<6;i++){
            if(bitWiseNumberCount[i]>0){
                numbersWithORS|=(1<<i);
            }
        }
         return numbersWithORS;
    }
}