public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int tot=n+m-1;
        n--;m--;
        while(n>=0){
            if(m<0||nums1[m]<nums2[n]){
                nums1[tot]=nums2[n--];
                
            }
            else{
               nums1[tot]=nums1[m--];
            }
            tot--;
        }
    }
}