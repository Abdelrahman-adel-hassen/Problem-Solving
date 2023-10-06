public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int valIndex=2;
        int numsLength=nums.Length;
        for(int i=2;i<numsLength;i++){
            if(nums[i]!=nums[valIndex-2]){
              nums[valIndex++]=nums[i];
            }
               
        }
        return Math.Min(valIndex,numsLength);
    }
}