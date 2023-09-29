public class Solution {
    public bool CanPermutePalindrome(string s) {
          int[] arr =new int[26];
        int len=s.Length;
        for(int i=0;i<len;i++){
            char ch=s[i];
            arr[ch-'a']++;
        }
        int cnt=0;
        for(int i=0;i<26;i++){ 
            cnt+=arr[i]%2;
        }
        return cnt<2;
    }
}