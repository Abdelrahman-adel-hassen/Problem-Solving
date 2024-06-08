public class Solution {
    public int[] CircularGameLosers(int n, int k)
    {
        bool[] game = new bool[n];

        for (int i = 0, j = 0; !game[i]; i = (i + ++j * k) % n)
        {
            game[i] = true;
        }

        var losers = new List<int>();

        for (int i = 0; i < game.Length; i++)
        {
            if (!game[i])
            {
                losers.Add(i + 1);
            }
        }

        return losers.ToArray();
    }
}