class Solution {
public:
    vector<int> findErrorNums(vector<int>& nums) {
        vector<int>v;
        for(int i=0;i<(int)nums.size();i++){
            int x=abs(nums[i]);
            if(nums[x-1]<0)v.push_back(x);
            nums[x-1]=-abs(nums[x-1]);
        }
        for(int i=0;i<(int)nums.size();i++)
            if(nums[i]>0)v.push_back(i+1);
        
        return v;
    }
};