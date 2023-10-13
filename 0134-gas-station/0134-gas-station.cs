public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int ans=-1;
        int sum=0;
        int n=gas.Length;
        for(int i=0;i<2*n;i++){
            int index=i%n;
            sum+=gas[index]-cost[index];
         //   Console.WriteLine(sum+" "+index+" "+i);
            if(index==ans)
                return index;
            if(sum<0){
                ans=-1;                
                sum=0;
            }
            else if(ans==-1)
                ans=index;
        }
        return -1;
    }
}