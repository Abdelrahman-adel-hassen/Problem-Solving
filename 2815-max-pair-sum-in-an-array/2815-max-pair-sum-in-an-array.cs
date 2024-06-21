public class Solution {
    public int MaxSum(int[] nums) {
         var map=new Dictionary<int, (int firsMax,int secondMax)>();
 int result=-1;
 foreach(var num  in nums)
 {
     var maxDigit=num.ToString().Max()-'0';
     if (!map.ContainsKey(maxDigit))
         map[maxDigit] = (-1, -1);

     if(num> map[maxDigit].firsMax)
         map[maxDigit]=(num, map[maxDigit].firsMax);
     else if(num > map[maxDigit].secondMax)
         map[maxDigit] = (map[maxDigit].firsMax,num);

     if (map[maxDigit].secondMax != -1)
         result = Math.Max(result, map[maxDigit].secondMax + map[maxDigit].firsMax);
 }
 return result;
    }
}