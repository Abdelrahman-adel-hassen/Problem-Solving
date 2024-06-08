public class Solution {
    public bool CanMakeSquare(char[][] grid) {
        
        for (var i = 0; i < grid.Length - 1; i++)
            for (var j = 0; j < grid[0].Length - 1; j++)
                if( (grid[i][j] == grid[i + 1][j] && grid[i][j] == grid[i][j + 1]) ||
                    (grid[i][j] == grid[i + 1][j + 1] && grid[i][j] == grid[i][j + 1]) ||
                    (grid[i][j] == grid[i + 1][j] && grid[i][j] == grid[i + 1][j + 1]) ||
                    (grid[i][j + 1] == grid[i + 1][j + 1] && grid[i][j + 1] == grid[i + 1][j]))
                    return true;           
        return false;
    }
}
