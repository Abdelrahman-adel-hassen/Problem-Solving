public class Solution {
    public int IsWinner(int[] player1, int[] player2) {
        
        if(player1.Count()==1)
            return GetTheWinner(player1[0],player2[0]);
     
        int score1=player1[0]+player1[1]*(player1[0]==10?2:1);
        int score2=player2[0]+player2[1]*(player2[0]==10?2:1);
       for(int i=2;i<player1.Count();i++){
          score1+=player1[i];
          score2+=player2[i];
          if(player1[i-1]==10||player1[i-2]==10)
                  score1+=player1[i];
          if(player2[i-1]==10||player2[i-2]==10)
                  score2+=player2[i];

       }

       return GetTheWinner(score1,score2);
    }
    private int GetTheWinner(int score1,int score2){
        if(score1==score2)
            return 0;
        return  score1>score2?1:2;
    }
}