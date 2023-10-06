public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int valIndex=1;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]!=nums[valIndex-1]){
              nums[valIndex++]=nums[i];
            }
               
        }
        return valIndex;
    }
}

