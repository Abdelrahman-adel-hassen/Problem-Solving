public class Solution {
    public long MinimalKSum(int[] nums, int k) {
        Array.Sort(nums);
        long result = 0, n = nums.Length;
        var diff = GetTheDiffernece(0, Math.Min(nums[0] - 1, k));
        result += diff;
        k -= Math.Min(nums[0] - 1, k);

        for (int i = 1; i < n && k > 0; i++)
        {
            int a=nums[i - 1];
            int b=nums[i];
            if(b-a<=1)
                continue;
            diff = GetTheDiffernece(a, Math.Min(b - 1, a + k));
            result += diff;
            k -= Math.Min(b - a - 1, k);
        }
        diff = GetTheDiffernece(nums[n - 1], nums[n - 1] + k);
        result += diff;
        return result;
    }
    long GetTheDiffernece(long a, long b)
    {
        return (b * (b + 1) / 2) - (a * (a + 1) / 2);
    }
}