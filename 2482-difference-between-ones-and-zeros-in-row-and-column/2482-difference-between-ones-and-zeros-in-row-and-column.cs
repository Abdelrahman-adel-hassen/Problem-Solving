public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int sumOfRowZero=0;
        int rows=grid.Length;
        int cols=grid[0].Length;
        for(int i=0;i<rows;i++){
           for(int j=0;j<cols;j++){
               if(i==0)
                   sumOfRowZero+=grid[i][j];
               else if(j==0)
                   grid[0][0]+=grid[i][j];
               else{
                   grid[i][0]+=grid[i][j];
                   grid[0][j]+=grid[i][j];
               }
               
           }
        }

        for(int i=1;i<rows;i++){
           for(int j=1;j<cols;j++){
              grid[i][j]=2*grid[0][j]-rows+2*grid[i][0]-cols;
           }
        }
        for(int j=1;j<cols;j++){
           grid[0][j]= 2*grid[0][j]-rows+2*sumOfRowZero-cols;
        }
        for(int i=1;i<rows;i++){
          grid[i][0]= 2*grid[0][0]-rows+2*grid[i][0]-cols;
        }
        grid[0][0]=2*grid[0][0]-rows+2*sumOfRowZero-cols;
        
        return grid;
    }
}