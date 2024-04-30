public class Solution {
    public int MySqrt(int x) {
        long l=0,r=x/2+1;
        while(l<r){
            long mid=(l+r+1)/2;
            if(mid*mid>x)
                r=mid-1;
            else 
                l=mid;
        }
        return (int)l;
    }
}