public class Solution {
    public int LongestAlternatingSubarray(int[] nums, int threshold) {
          //if We found even and break the role restar ans=1

        //even and ans%2==1 ans=1,even ans%2==0 ans++ 
        //odd and  ans%2==0 ans=0, ans%2==1  ans++ 
        int maxLongest=0,result=0;
        for(int i=0;i<nums.Count();i++){
            if(nums[i]>threshold){
                maxLongest=0;
                continue;
            }
            if(nums[i]%2==0)
                maxLongest=maxLongest%2==1?1:maxLongest+1;
            else
                 maxLongest=maxLongest%2==0?0:maxLongest+1;
            result=Math.Max(result,maxLongest);
        }
        return result;
    }
}