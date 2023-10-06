public class Solution {
    public int MaxProfit(int[] prices) {
         int mxProfit=0;
        int minimumProfit=prices[0];
        for(int i=1;i<prices.Length;i++){
            int currentProfit=prices[i]-minimumProfit;
            mxProfit=Math.Max(mxProfit,currentProfit);
            minimumProfit=Math.Min(minimumProfit,prices[i]);
        }
        return mxProfit;
    }
}