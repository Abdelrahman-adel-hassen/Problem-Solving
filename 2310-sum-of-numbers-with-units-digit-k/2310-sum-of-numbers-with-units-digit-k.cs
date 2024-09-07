public class Solution {
    public int MinimumNumbers(int num, int k)
    {
       if (num == 0) return 0;
        //(x*10+k)+(y*10+k)=num;
        //(x+y)*10+2k+num
       for(int i=1;i<=10;i++){
           int numTemp=num-i*k;
           if(numTemp<0)
               break;
           if(numTemp%10==0)
               return i;
       }
        
        return -1;
    }
}