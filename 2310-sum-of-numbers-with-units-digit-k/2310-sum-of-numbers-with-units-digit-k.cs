public class Solution {
    public int MinimumNumbers(int num, int k)
    {
       if (num == 0) return 0;
       for(int i=1;i<=num;i++){
           int numTemp=num-i*k;
           if(numTemp<0)
               break;
           if(numTemp%10==0)
               return i;
       }
        
        return -1;
    }
}