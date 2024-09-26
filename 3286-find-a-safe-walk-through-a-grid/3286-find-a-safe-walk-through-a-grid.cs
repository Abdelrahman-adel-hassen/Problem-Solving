public class Solution {
    public bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
           var vis = new bool[51, 51,101];
        var dp = new short[51, 51, 101];
        var isSafe = Solve(0, 0, grid, vis, dp, health);
        return isSafe;
    }
    bool Solve(int i, int j, IList<IList<int>> grid, bool[,,] vis, short[,,] dp, int health)
    {
        if (i < 0 || i == grid.Count || j < 0 || j == grid[0].Count)
            return false;
        if (grid[i][j] == 1)
            health--;
        if (health == 0)
            return false;
        if (i == grid.Count - 1 && j == grid[0].Count - 1)
            return true;
        if (vis[i, j,health])
            return false;
       vis[i, j, health] = true;

        //if (dp[i, j, health] != 0)
        //    return dp[i, j, health] == 1 ? true : false;
        var isSafe = Solve(i + 1, j, grid, vis, dp, health) || Solve(i, j + 1, grid, vis, dp, health) || Solve(i, j - 1, grid, vis, dp, health) || Solve(i - 1, j, grid, vis, dp, health);
        //vis[i, j, health] = false;
        dp[i, j, health] = isSafe ? (short)1 : (short)2;
        return isSafe;
    }

}