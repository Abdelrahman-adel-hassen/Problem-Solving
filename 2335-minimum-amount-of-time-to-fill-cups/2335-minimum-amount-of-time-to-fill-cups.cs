public class Solution {
    public int FillCups(int[] amount) {
        Array.Sort(amount);
        int res=0;
        if(amount[0]+amount[1]>amount[2])
            res=amount[1]+amount[0]-amount[2];
        return amount[2]+(res+1)/2;
    }
}
