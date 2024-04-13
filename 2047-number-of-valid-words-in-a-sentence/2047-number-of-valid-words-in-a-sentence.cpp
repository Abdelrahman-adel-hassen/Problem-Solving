class Solution {
public:
    void pass(int &i,string &s,const int &n,bool &start,bool &hypen){
        start = true;hypen = false;
        for(;i<n;i++) if(s[i] == ' ') break;
    }
    int countValidWords(string s) {
        int ans = 0;
        const int n = s.size();
        bool hypen = false,start = true;
        for(int i = 0;i<n;i++){
            if(s[i] == ' '){start = true; hypen = false;continue;}
            if(s[i] >= '0' && s[i] <= '9') pass(i,s,n,start,hypen);
            else if(s[i] == '-'){
                if(start || hypen || i == n - 1 || !(s[i + 1] >= 'a' && s[i + 1] <= 'z')) pass(i,s,n,start,hypen);
                else hypen = true;
            }
            else if(s[i] == '!' || s[i] == '.' || s[i] == ','){
                if(i != n - 1 && s[i + 1] != ' ') pass(i,s,n,start,hypen);
                else ans++;
            }
            else if(s[i] >= 'a' && s[i] <= 'z' && (i == n - 1 || s[i + 1] == ' ')){ ans++;}
            if(s[i] != ' ') start = false;
        }
        return ans;
    }
};