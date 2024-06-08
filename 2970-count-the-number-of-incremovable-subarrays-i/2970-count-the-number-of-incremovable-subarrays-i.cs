public class Solution {
    public int IncremovableSubarrayCount(int[] nums) {
        int answer=0;
        bool isDone;
        for(int i=0;i<nums.Count();i++){
            if(i>1&&nums[i-1]<=nums[i-2])
                break; 
            answer++;
            for(int j=i;j<nums.Count()-1;j++){
                isDone=true;
                if(i>0&&nums[j+1]<=nums[i-1]){
                    isDone=false;
                }
                else{
                    for(int k=j+2;k<nums.Count();k++){
                        if(nums[k]<=nums[k-1]){
                            isDone=false;
                            break;
                        }
                    } 
                }
                if(isDone)
                    answer++;
            }
        }
        return answer;
    }
}