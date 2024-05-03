public class Solution {
    public int DistanceTraveled(int mainTank, int additionalTank) {
        int distance=0;
        while(mainTank>=5){
            int totalTankExecuting=mainTank/5;
            distance+=totalTankExecuting*5*10;
            mainTank-=totalTankExecuting*5;
            mainTank+=Math.Min(additionalTank,totalTankExecuting);;
            additionalTank-=Math.Min(additionalTank,totalTankExecuting);
        
        }
        return distance+mainTank*10;
    }
}