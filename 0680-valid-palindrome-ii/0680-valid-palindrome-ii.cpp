class Solution {
public:
    bool validPalindrome(string s) {
        int l=0,r=s.size()-1;
        while(l<r&&s[l]==s[r]){
            l++;
            r--;
        }
        if(l>=r)
            return true;
        int l1=l+1,r1=r;
        while(l1<r1&&s[l1]==s[r1]){
            l1++;
            r1--;
        }
        if(l1>=r1)
            return true;
        int l2=l,r2=r-1;
        while(l2<r2&&s[l2]==s[r2]){
            l2++;
            r2--;
        }
        if(l2>=r2)
            return true;
        return false;
    }
};