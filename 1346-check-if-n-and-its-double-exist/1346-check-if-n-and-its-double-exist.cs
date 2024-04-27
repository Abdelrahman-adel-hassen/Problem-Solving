public class Solution {
    public bool CheckIfExist(int[] arr) {
        Dictionary<int,bool> mp=new Dictionary<int,bool>();
        for(int i=0;i<arr.Count();i++){
            if(mp.ContainsKey(arr[i]*2)||(arr[i]%2==0&&mp.ContainsKey(arr[i]/2)))
                return true;
            mp[arr[i]]=true;
        }
        return false;
    }
}