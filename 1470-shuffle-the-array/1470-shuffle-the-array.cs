public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int lenOfNums=nums.Length;
        
        for(int i=0;i<lenOfNums/2;i++){
            int num=nums[i+n]<<10;
            nums[i]|=num;
        }
        int ones=(1<<10)-1;
        for(int i=n-1;i>=0;i--){
            int firstNum=nums[i]>>10;
            int secondNum=nums[i] & ones;
            nums[i*2]=secondNum;
            nums[i*2+1]=firstNum ;
        }
        return nums;
    }
}