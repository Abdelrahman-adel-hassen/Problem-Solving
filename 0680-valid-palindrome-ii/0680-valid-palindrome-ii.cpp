class Solution {
public:
    bool validPalindrome(string s) {
        int l=0,r=s.size()-1;
        if(IsvalidPalindrome(s,l,r))
            return true;
        int l1=l+1,r1=r;
        if(IsvalidPalindrome(s,l1,r1))
            return true;
        int l2=l,r2=r-1;
        if(IsvalidPalindrome(s,l2,r2))
            return true;
        return false;
    }
    bool IsvalidPalindrome(string &s,int &l,int &r){
        while(l<r&&s[l]==s[r]){
            l++;
            r--;
        }
         return l>=r;
    }
};