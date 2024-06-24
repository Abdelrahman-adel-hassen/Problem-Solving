public class Solution {
    public long MaximumSubarraySum(int[] nums, int k) {
     
        List<long> numsTemp = new();
        numsTemp.Add(0);
        for (int i = 1; i <= nums.Length; i++)
            numsTemp.Add(nums[i - 1] + numsTemp[i - 1]);

        long result = long.MinValue;
        Dictionary<int, int> numbersCount = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numbersCount.ContainsKey(k + nums[i]))
                result = Math.Max(numsTemp[i + 1] - numsTemp[numbersCount[k + nums[i]]], result);

            if (numbersCount.ContainsKey(nums[i] - k))
                result = Math.Max(numsTemp[i + 1] - numsTemp[numbersCount[nums[i] - k]], result);
            
            if (!numbersCount.ContainsKey(nums[i])|| nums[i]>numsTemp[i+1]-numsTemp[numbersCount[nums[i]]])
                numbersCount[nums[i]] = i;
            
        }

        return result == long.MinValue ? 0 : result;
    }
}
