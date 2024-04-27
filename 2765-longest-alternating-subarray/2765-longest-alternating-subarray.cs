public class Solution {
    public int AlternatingSubarray(int[] nums) {
        int maxAlternating=-1;
        int currentMaxAlternating=1;
        int expectedResult=1;
        for(int i=1;i<nums.Count();i++){
            if(nums[i]-nums[i-1]!=expectedResult){
                currentMaxAlternating=1;          
                expectedResult=1;
                if(nums[i]-nums[i-1]!=1)
                    continue;
            }
           currentMaxAlternating++;
           expectedResult*=-1;
           maxAlternating=Math.Max(maxAlternating,currentMaxAlternating); 
           
        }
        return maxAlternating;
    }
}