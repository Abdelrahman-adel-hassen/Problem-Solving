public class Solution {
    public bool IsPossibleToCutPath(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;

        if (n == 1 || m == 1)
            return n + m > 3;

        return !NumberOfPaths(1, 0, n, m, grid) || !NumberOfPaths(0, 1, n, m, grid);
    }
    public bool NumberOfPaths(int i, int j, int n, int m, int[][] grid)
    {
        if (i == n - 1 && j == m - 1)
            return true;
        if (i == n || j == m || grid[i][j] == 0)
            return false;
        grid[i][j] = 0;
        return NumberOfPaths(i + 1, j, n, m, grid) || NumberOfPaths(i, j + 1, n, m, grid);
    }

}