class Solution {
public:
    int romanToInt(string s) {
        unordered_map<char,int>mp{{'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}};
        int n=s.size();
        int total =mp[s[n-1]];
        for(int i=0;i<n-1;i++){
              total+=mp[s[i]]<mp[s[i+1]]?-mp[s[i]]:+mp[s[i]];
        }
        return total;
    }
};