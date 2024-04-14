public class Solution {
    public int MissingInteger(int[] nums) {
        int maxNumberOfLongestSequentialPrefix=GetSumOfLongestSequentialPrefix(nums);
        return GetSmallestNumberMissigGreterThanSum(nums,maxNumberOfLongestSequentialPrefix);
    }
    private int GetSumOfLongestSequentialPrefix(int[] nums){
        int sum=nums[0];
        for(int i=1;i<nums.Count();i++){
            if(nums[i]!=nums[i-1]+1)
                break;
           sum+=nums[i];
        }
    
        return sum;
    }
    private int GetSmallestNumberMissigGreterThanSum(int[]nums,int sum){
        var numbers=new Dictionary<int,bool>();
        for(int i=0;i<nums.Count();i++){
            numbers[nums[i]]=true;
        }
        
         while(numbers.ContainsKey(sum)){
             sum++;
         }
        return sum;
    }
}