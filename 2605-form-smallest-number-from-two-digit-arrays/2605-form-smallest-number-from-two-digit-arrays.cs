public class Solution
{
    public int MinNumber(int[] nums1, int[] nums2)
    {
        var hash1 = 0;
        var hash2 = 0;

        foreach (var num in nums1)
            hash1 |= 1 << num;

        foreach (var num in nums2)
            hash2 |= 1 << num;

        if ((hash1 & hash2) != 0)
            return int.TrailingZeroCount(hash1 & hash2);

        var num1 = int.TrailingZeroCount(hash1);
        var num2 = int.TrailingZeroCount(hash2);
        return num1 < num2 ? num1 * 10 + num2 : num2 * 10 + num1;
    }
}