public class RandomizedSet {

    Dictionary<int,int> nums;
    List<int>values;
    Random random;
    public RandomizedSet() {
        nums=new Dictionary<int,int>(); 
        values=new List<int>();
        random=new Random();
    }
    
    public bool Insert(int val) {
        if(nums.ContainsKey(val))
            return false;
        nums[val]=values.Count;
        values.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(!nums.ContainsKey(val))
            return false;
        int index=nums[val];
        int value=values[index]=values[GetValuesSize()-1];
        values.RemoveAt(GetValuesSize()-1);
        nums[value]=index;
        nums.Remove(val);
        return true;
    }
    
    private int GetValuesSize()=> values.Count;

    public int GetRandom()=> values[random.Next(GetValuesSize())];
    
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */