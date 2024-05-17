class Solution {
public:
    int maximumProduct(vector<int>& nums) {
        int n=nums.size();
        int arr[5]={};
        arr[4]=arr[3]=arr[2]=INT_MIN;
        arr[0]=arr[1]=INT_MAX;
        for(int i=0;i<n;i++){
            if(arr[4]<nums[i]){
                arr[2]=arr[3];
                arr[3]=arr[4];
                arr[4]=nums[i];
            }
            else if(arr[3]<nums[i]){
                arr[2]=arr[3];
                arr[3]=nums[i];
            }
            else if(arr[2]<nums[i]){
                arr[2]=nums[i];
            }
            if(arr[1]>nums[i]){
                arr[0]=arr[1];
                arr[1]=nums[i];
            }
            else if(arr[0]>nums[i]){
                arr[0]=nums[i];
            }
        }
        for(int i=0;i<5;i++){
            cout<<arr[i]<<" ";
        }
        return max(arr[4]*arr[3]*arr[2],arr[0]*arr[1]*arr[4]);
    }
};