public class Solution 
{
     public int MinOperations(IList<int> nums, int k)
     {
         long mask = 0;
         int count = 0;
         long required = (1L << (k + 1)) - 2; // Zero is not there

         for (int i = nums.Count - 1; i >= 0; i--)
         {
             if(nums[i] <= k)
             {
                mask |= (1L << nums[i]);
             }
             
             count++;

             if (mask == required)
             {
                 return count;
             }        
         }

         return count;
     }
}