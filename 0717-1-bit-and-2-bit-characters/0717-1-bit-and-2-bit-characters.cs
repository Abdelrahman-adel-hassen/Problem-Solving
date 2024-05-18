public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int onesOrZeros=0;
        for(int i=0;i<bits.Count()-1;i++){
          onesOrZeros+=bits[i];
          onesOrZeros=onesOrZeros%2;
          if(bits[i]==0)
              onesOrZeros=0;
              
        }
        return onesOrZeros%2==0;
    }
}