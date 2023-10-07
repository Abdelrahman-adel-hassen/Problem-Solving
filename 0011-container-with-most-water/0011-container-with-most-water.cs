public class Solution {
    public int MaxArea(int[] height) {
        int n=height.Length;
        int l=0,r=n-1;
        int maxAmountOfWater=0;
        while(l<r){
            int minHeight=Math.Min(height[l],height[r]);
            maxAmountOfWater=Math.Max(minHeight*(r-l),maxAmountOfWater);
            if(height[l]<height[r])
                l++;
            else
                r--;
            
        }
        return maxAmountOfWater;
    }
}