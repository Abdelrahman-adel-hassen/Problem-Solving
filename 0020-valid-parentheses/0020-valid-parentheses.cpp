class Solution {
public:
    bool isValid(string s) {
        stack<int>st;
        for(char ch:s){
            if(ch=='('||ch=='{'||ch=='[')st.push(ch);
            else{
                if(st.empty())return 0;
                char c=st.top();
                if(abs(ch-c)>2)return 0;
                st.pop();
            }
        }
        return st.empty();
    }
};