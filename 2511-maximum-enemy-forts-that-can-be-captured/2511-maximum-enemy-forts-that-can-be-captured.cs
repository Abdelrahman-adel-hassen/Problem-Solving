public class Solution {
    public int CaptureForts(int[] forts) {
        bool noFort=false;
        bool fort=false;
        int answer=0;
        int noEnemies=0;
        for(int i=0;i<forts.Count();i++){
            if(forts[i]==0)
                noEnemies++;
            else if(forts[i]==-1){
                noFort=true;
                if(fort)
                   answer=Math.Max(answer,noEnemies);
                noEnemies=0;
                fort=false;
            }
            else{
                fort=true;
                if(noFort)
                   answer=Math.Max(answer,noEnemies);
                noEnemies=0;
                noFort=false;
            }
        }
        return answer;
    }
}