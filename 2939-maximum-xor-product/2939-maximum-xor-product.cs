public class Solution {
    public int MaximumXorProduct(long a, long b, int n)
    {
        const int mod = 1000000007;
        for (int i = n - 1; i >= 0; --i)
        {
            long c = a;
            a = Math.Min(a, b);
            b = Math.Max(b, c);
            bool aNeedToIncrease = ((a >> i) & 1) == 0;
            bool bNeedToIncrease = ((b >> i) & 1) == 0;
            if (!aNeedToIncrease && !bNeedToIncrease)
                continue;
            long tempOne = 1;
            if (aNeedToIncrease && bNeedToIncrease)
            {
                a |= tempOne << i;
                b |= tempOne << i;
            }
            else if (aNeedToIncrease)
            {
                a |= tempOne << i;
                b ^= tempOne<< i;
            }
        }
        return (int)(((a % mod) * (b % mod)) % mod);
    }
}