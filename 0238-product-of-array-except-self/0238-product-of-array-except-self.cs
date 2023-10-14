public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product=1,numOfZeros=0;
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0)
              product=GetProduct(product,nums[i]);
            else 
            numOfZeros++;
        }
        Console.WriteLine(product+" "+numOfZeros);
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){
                if(numOfZeros<=1)
                    nums[i]=product;
                else 
                    nums[i]=0;
            }
            else
                nums[i]=numOfZeros>0?0:product/nums[i];
        }
        return nums;
    }
    private int GetProduct(int firstNum,int seconNum){
        int product=0;
        bool isPostive=((firstNum+seconNum)/seconNum)>0;
        firstNum=Math.Abs(firstNum);
        seconNum=Math.Abs(seconNum);
        while(firstNum>0){
            int lastNumBitNumber=(firstNum&1);
            if(lastNumBitNumber==1)
                product+=seconNum;
            firstNum>>=1;
            seconNum<<=1;
        }
        return product/(isPostive?1:-1);
    }
}