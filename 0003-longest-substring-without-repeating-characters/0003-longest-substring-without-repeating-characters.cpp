class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int n=s.size();
        unordered_map<char,short>mp;
        int mx=0,ans=0,l=0;
        for(int i=0;i<n;i++){
            mp[s[i]]++;
            mx++;
            while(mp[s[i]]>1){
                mp[s[l++]]--;
                mx--;    
            } 
            ans=max(mx,ans);
        }
        return ans;
        
    }
};
