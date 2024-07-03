public class Solution {
    public int MinOperations(int[] nums, int k) {
        var numbersSorted = new PriorityQueue<long, long>();
        foreach (int num in nums)
            numbersSorted.Enqueue(num, num);

        int operations = 0;
        while (numbersSorted.Count > 0 && numbersSorted.Peek() < k)
        {
            long x = numbersSorted.Dequeue();
            long y = numbersSorted.Dequeue();
            operations++;
            long newValue = x * 2 + y;
            numbersSorted.Enqueue(newValue, newValue);
        }
        return operations;
    }
}