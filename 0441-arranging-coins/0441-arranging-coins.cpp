class Solution {
public:
    int arrangeCoins(int n) {
        int l=0,r=n;
        while(l<r){
            long mid=((long)r+l+1)/2;
            if(mid*(mid+1)/2>n)r=mid-1;
            else l=mid;
        }
        return l;
    }
};