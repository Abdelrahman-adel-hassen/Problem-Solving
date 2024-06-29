public class Solution {
    public long NumberOfPairs(int[] nums1, int[] nums2, int k) {
         Dictionary<int, int> counters = new();
        foreach (var num in nums1)
        {
            if (num % k != 0)
                continue;
            var newNumber = num / k;
            for (int i = 1; i * i <= newNumber; i++)
            {
                if (newNumber % i != 0)
                    continue;

                if (!counters.ContainsKey(i))
                    counters[i] = 0;
                counters[i]++;

                if (newNumber == i * i)
                    continue;
                if (!counters.ContainsKey(newNumber / i))
                    counters[newNumber / i] = 0;
                counters[newNumber / i]++;
            }

        }
        long result = 0;
        foreach (var num in nums2)
        {
            if(counters.ContainsKey(num))
                result += counters[num];
        }
        return result;
    }
}