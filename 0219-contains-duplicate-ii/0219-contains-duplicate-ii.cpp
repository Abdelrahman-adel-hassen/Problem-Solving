class Solution {
public:
    bool containsNearbyDuplicate(vector<int>& nums, int k) {
        int l=0,r=0,n=nums.size();
        map<int,int>mp;
        if(!n||!k)return 0;
        while(r<n){
          //  cout<<r<<" "<<l<<" "<<mp[r]<<endl;
            if(r-l>k)mp[nums[l++]]--;
            if(mp[nums[r]])return 1;
            mp[nums[r++]]++;
        }
        return 0;
    }
};