public class Solution {
    public int MinFlips(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        bool removeOnes1 = false;
        bool isOne = false;
        int ans = 0;
        int totalOnes = 0;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            for (int j = 0; j < (m + 1) / 2; j++)
            {
                int ones = 0;
                int numOfSquares = 4;
                if (n - i - 1 == i && m - j - 1 == j)
                    numOfSquares = 1;
                else if (n - i - 1 == i || m - j - 1 == j)
                    numOfSquares = 2;

                if (numOfSquares == 2)
                {
                    ones = (grid[i][j] == 1 ? 1 : 0) + (grid[n - i - 1][m - j - 1] == 1 ? 1 : 0);
                    if (ones == 1)
                    {
                        ans++;
                        removeOnes1 = true;
                        ones--;
                    }
                    totalOnes += ones;
                }
                else if (numOfSquares == 4)
                {
                    ones = (grid[i][j] == 1 ? 1 : 0) + (grid[i][m - j - 1] == 1 ? 1 : 0) + (grid[n - i - 1][j] == 1 ? 1 : 0) + (grid[n - i - 1][m - j - 1] == 1 ? 1 : 0);
                    ans += Math.Min(ones, 4 - ones);
                    totalOnes += ones > 2 ? 4 : 0;
                }
                else
                    ans += (grid[i][j] == 1 ? 1 : 0);

            }
        }
        if (totalOnes % 4 == 0)
            return ans;
        return ans + (removeOnes1 ? 0 : 2);
    }
}