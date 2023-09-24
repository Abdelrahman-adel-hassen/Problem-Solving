public class Solution {
    public int TwoSumLessThanK(int[] nums, int k) {
     //Dictionary<int,int>dic=new Dictionary<int,int>();
     int mx=-1;
     for(int i=0;i<nums.Count();i++){
           for(int j=i+1;j<nums.Count();j++){
               var sum=nums[i]+nums[j];
                if(sum<k)
                    mx=Math.Max(mx,sum);
             }
     }
        return mx;
    }
}