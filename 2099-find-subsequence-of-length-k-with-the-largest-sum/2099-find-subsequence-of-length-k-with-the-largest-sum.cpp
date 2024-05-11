class Solution {
public:
    vector<int> maxSubsequence(vector<int>& nums, int k) {
        priority_queue<int,vector<int>,greater<>>pq;
        for(int num:nums){
            pq.push(num);
        }
        while(pq.size()>k){
            pq.pop();  
        }
        unordered_map<int,int>mp;
        while(!pq.empty()){
            mp[pq.top()]+=1;
            pq.pop();  
        }
        vector<int>ans;
        for(int i=0;i<nums.size();i++){
            if(mp[nums[i]]){
                mp[nums[i]]--;
                ans.push_back(nums[i]);
               
            }
        }
        return ans;
    }
};