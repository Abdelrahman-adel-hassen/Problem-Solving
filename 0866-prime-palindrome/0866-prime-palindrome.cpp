class Solution {
public:
    int primePalindrome(int n) {
        int mx=2e8;
        if(n==1)return 2;
        for(int i=n;i<=mx;i++){
            if (10000000 < i && i < 100000000)
                   i= 100000000;
            if(ispal(i)){
                  for(int j=2;j*j<=i;j++){
                      if(i%j==0)goto flag;
                  }
                  return i;
            }
             flag:;
           
           
        }
        return 2;
    }
    bool ispal(int num){
        int n=0;
        while(num>n){
            n=n*10+num%10;
            num/=10;
        }
        return n==num||n/10==num;
    }
};