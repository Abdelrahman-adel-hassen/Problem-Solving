class Solution {
public:
    bool isPalindrome(int n) 
    { 
        int reverse = 0; 
        int temp = n; 
        while (temp != 0) { 
            reverse = (reverse * 10) + (temp % 10); 
            temp = temp / 10; 
        } 
        return (reverse == n);
    }

    long long minimumCost(vector<int>& nums) {
        int n = nums.size();
        sort(begin(nums), end(nums));
        int median = nums[n/2];
        long long a = median, b = median;
        while (true) {
            if (isPalindrome(a)) break;
            a--;
        }
        while (true) {
            if (isPalindrome(b)) break;
            b++;
        }

        long long ans1 = 0, ans2 = 0;
        for (int i = 0; i < n; i++) {
            ans1 += abs(nums[i] - a);
            ans2 += abs(nums[i] - b);
        }
        return min(ans1, ans2);
        
    }
};
