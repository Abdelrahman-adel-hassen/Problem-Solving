public class Solution {
    public int[][] SortTheStudents(int[][] score, int k) {
        int[][] result = new int[score.Length][];
        SortedDictionary<int,int> sortedScores=new();
        for(int i=0;i<score.Length;i++){
            sortedScores.Add(score[i][k],i);
        }
        int index=score.Length-1;
        foreach(var sortedScore in sortedScores){
            result[index]=score[sortedScore.Value];
            index--;
        }
        return result;
    }
}