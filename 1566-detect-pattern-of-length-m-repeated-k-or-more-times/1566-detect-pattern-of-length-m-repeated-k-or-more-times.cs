public class Solution {
    public bool ContainsPattern(int[] arr, int m, int k) {
        int n=arr.Count();
        if(n<m)
            return false;
        if(n==m)
            return k==1;
        for(int i=m;i<n;i++){ 
            for(int j=i;j<n;j++){     
                if(arr[j]!=arr[j-m])
                    break;
                if(j-i+m+1==k*m)
                    return true;
            }

        }
        return false;

    }
}