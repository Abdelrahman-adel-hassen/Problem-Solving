class Solution {
public:
    int kConcatenationMaxSum(vector<int>& arr, int k) {
     static int MOD = 1000000007;
        
        int maxSum = 0;
        int sum = 0,actualsum=0;
        for (int i = 0; i < min(k,2); i++) {
            for (int num : arr) {
                sum = max(0, sum + num % MOD);
                if(!i)actualsum+=num;
                maxSum = max(maxSum, sum);
            }
           
        }
        //cout<<sum<<" "<<actualsum<<" "<<maxSum<<endl;
       if(k==1||actualsum<=0)return maxSum%MOD;
        return (maxSum +(k-2)*long(actualsum))%MOD;
        
    }
};
// 1 -2 1 1 -2 1  1 -2 1 1 -2 1
// 1 -1 1 2  0 1  2  0 1 2 0  1
//