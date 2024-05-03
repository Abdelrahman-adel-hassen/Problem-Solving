class Solution {
public:
    bool checkPerfectNumber(int num) {
        if(num<2)return 0;
        int i=2,sum=0;
        for(i;i*i<num;i++)
            if(num%i==0)sum+=i+num/i;
        if(i*i==num)sum+=i;
        sum++;
        return sum==num;
    }
};