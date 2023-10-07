class Solution {
public:
    bool isSubsequence(string s, string t) {
        int j=0,i=0;
        while(i<s.size()&&j<t.size()){
            if(s[i]==t[j])i++;
            j++;
        }
        return i==s.size();
    }
};