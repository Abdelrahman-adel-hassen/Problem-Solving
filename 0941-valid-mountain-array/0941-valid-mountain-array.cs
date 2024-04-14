public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int currentIndex=1;
        if(arr.Count()<3)
            return false;
        while(currentIndex<arr.Count()&&arr[currentIndex]>arr[currentIndex-1])
            currentIndex++;
        if(currentIndex==arr.Count()||currentIndex==1)
            return false;
        while(currentIndex<arr.Count()&&arr[currentIndex]<arr[currentIndex-1])
            currentIndex++;
        return currentIndex==arr.Count();
    }
}