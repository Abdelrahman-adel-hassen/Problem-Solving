public class Solution {
    public int MissingInteger(int[] nums) {
        int maxNumberOfLongestSequentialPrefix=GetSumOfLongestSequentialPrefix(nums);
        return GetSmallestNumberMissigGreterThanSum(nums,maxNumberOfLongestSequentialPrefix);
    }
    private int GetSumOfLongestSequentialPrefix(int[] nums){
        int maxNumberOfLongestSequentialPrefix=nums[0];
        int maxLongestSequentialPrefix=1;
        for(int i=1;i<nums.Count();i++){
            if(nums[i]!=nums[i-1]+1)
                break;
            maxLongestSequentialPrefix++;
           maxNumberOfLongestSequentialPrefix=nums[i];
        }
        int total1=(maxNumberOfLongestSequentialPrefix*(maxNumberOfLongestSequentialPrefix+1))/2;
        maxNumberOfLongestSequentialPrefix-=maxLongestSequentialPrefix;
        int total2=(maxNumberOfLongestSequentialPrefix*(maxNumberOfLongestSequentialPrefix+1))/2;
        return total1-total2;
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