class Solution {
public:
    bool check(unordered_map<int,int>&mp,int mid)
    {
       int ans = 0;
       for(auto &x:mp)
       {
           int a = x.second;
           int count_mid = 0;
           int count_prev = -1;
           int count = 0;
           while(a>0)
           {
               if(mid!=1 and a%(mid-1)==0)
               {
                   count_mid = count;
                   count_prev = a/(mid-1);
               }
               a-=mid;
               count++;
               if(a>0 and mid!=1 and a%(mid-1)==0)
               {
                   count_mid = count;
                   count_prev = a/(mid-1);
               }
           }
           if(a<0 and count_prev==-1)return false;
       }
        return true;
    }
    int minGroupsForValidAssignment(vector<int>& nums) {
        
        unordered_map<int,int>mp;
        int maxi = INT_MIN;
        for(auto &x:nums)
        {
            mp[x]++;
            maxi = max(maxi,mp[x]);
        }
        int ans = -1;
        for(int i=1;i<=maxi;i++)
        {
            if(check(mp,i))
            {
                ans = i;
            }
        }
        int sol = 0;
       for(auto &x:mp)
       {
           int a = x.second;
           if(ans==1)
           {
               sol+=a;
               continue;
           }
           int count_mid = 0;
           int count_prev = -1;
           int count = 0;
           while(a>=0)
           {
               if(ans!=1 and a%(ans-1)==0)
               {
                   count_mid = count;
                   count_prev = a/(ans-1);
               }
               a-=ans;
               count++;
               if(a>0 and ans!=1 and a%(ans-1)==0)
               {
                   count_mid = count;
                   count_prev = a/(ans-1);
               }
           }
           sol+=(count_mid+count_prev);
       }
        return sol;
    }
};