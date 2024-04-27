public class Solution {
    public int ThirdMax(int[] nums) {
        const int intialValue=Int32.MinValue;
        int firstMaxNumber=intialValue,SecondMaxNumber=intialValue,thirdMaxNumber=intialValue;
        bool firstMaxNumberIsUpdated=false,secondMaxNumberIsUpdated=false,thirdMaxNumberIsUpdated=false;
        for(int i=0;i<nums.Count();i++){
            if(nums[i]>=firstMaxNumber){
                if(firstMaxNumberIsUpdated&&nums[i]!=firstMaxNumber){      
                     if(secondMaxNumberIsUpdated)
                         thirdMaxNumberIsUpdated=true;
                     secondMaxNumberIsUpdated=true;
                     thirdMaxNumber=SecondMaxNumber;
                     SecondMaxNumber=firstMaxNumber;                  
                }
                firstMaxNumber=nums[i];   
                firstMaxNumberIsUpdated=true;
            }
            else if(nums[i]>=SecondMaxNumber){
                if(secondMaxNumberIsUpdated&&nums[i]!=SecondMaxNumber){
                    thirdMaxNumber=SecondMaxNumber;
                    thirdMaxNumberIsUpdated=true;
                }
                secondMaxNumberIsUpdated=true;
                SecondMaxNumber=nums[i];
            }
            else if(nums[i]>=thirdMaxNumber){
                thirdMaxNumberIsUpdated=true;
                thirdMaxNumber=nums[i];    
            }
        }
        return thirdMaxNumberIsUpdated?thirdMaxNumber:firstMaxNumber;
    }
}