public class Solution {
    public int DiagonalPrime(int[][] nums) {
        int maxNumber=0;
        int numsLength=nums.Length;
       for(int i=0;i<numsLength;i++){
          if(IsPrime(nums[i][i]))
             maxNumber=Math.Max(maxNumber,nums[i][i]);
          if(IsPrime(nums[i][numsLength-1-i]))
             maxNumber=Math.Max(maxNumber,nums[i][numsLength-1-i]);
       } 
       return maxNumber;
    }
    public bool IsPrime(int num){
        if(num==1)
            return false;

        if(num%2==0)
            return num==2;
        for(int i=3;i*i<=num;i+=2){
            if(num%i==0)
                return false;
        }
        return true;
    }
}