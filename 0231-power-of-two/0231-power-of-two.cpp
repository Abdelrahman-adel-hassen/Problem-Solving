class Solution {
public:
    bool isPowerOfTwo(int n) {
        long nn=n;
        return nn!=0&&(nn&(nn-1))==0;
    }
};