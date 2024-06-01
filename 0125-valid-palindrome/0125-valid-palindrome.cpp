class Solution {
public:
    bool isPalindrome(string s) {
        int i= 0, j = s.size()-1;
        while(i<j){
           // cout<<s[i]<<" "<<s[j]<<endl;
            while(i<j&&!(isalpha(s[i])||isdigit(s[i]))) i++;
            while(i<j&&!(isalpha(s[j])||isdigit(s[j]))) j--;
            s[i]=tolower(s[i]);
            s[j]=tolower(s[j]);
           // cout<<i<<" "<<j<<" "<<s[i]<<" "<<s[j]<<endl;
            if(s[i++]!=s[j--])return 0;
        }
        return 1;
    }
};