class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int sz=(int)nums.size();
        vector<int>v(sz);
        int res=1;
        v[0]=1;
        for(int i=0;i<sz;i++)
            v[i]=res,res*=nums[i];
        
        res=1;
        
        for(int i=sz-1;i>=0;i--){
            v[i]=v[i]*res;
            res*=nums[i];
        }
        return v;
    }
};