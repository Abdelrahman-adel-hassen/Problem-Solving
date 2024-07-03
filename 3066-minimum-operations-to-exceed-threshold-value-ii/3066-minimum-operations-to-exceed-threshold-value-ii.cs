public class Solution {
    public int MinOperations(int[] nums, int k) {
        int operations = 0;
        var numbersGreaterOrEqualK = nums.Count(x => x >= k);
        if (numbersGreaterOrEqualK == nums.Length)
            return operations;

        var numbersSorted = new PriorityQueue<long, long>();
        foreach (int num in nums)
            numbersSorted.Enqueue(num, num);

        while (numbersGreaterOrEqualK != numbersSorted.Count)
        {
            long x = numbersSorted.Dequeue();
            long y = numbersSorted.Dequeue();
            if (y >= k)
                numbersGreaterOrEqualK--;
            operations++;
            long newValue = x * 2 + y;
            numbersSorted.Enqueue(newValue, newValue);
            if (newValue >= k)
                numbersGreaterOrEqualK++;
        }
        return operations;
    }
}