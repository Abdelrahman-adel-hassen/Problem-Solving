public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
            List<int> result = new List<int>();
            Array.Reverse(num);

            int n = num.Length;
            int i = 0;
            do
            {
                int currNum = i < n ? num[i] : 0;
                int newNum = currNum + k;
                k = newNum / 10;
                newNum %= 10;
                result.Add(newNum);
                i++;
            } while (k > 0 || i < n);

            result.Reverse();
            return result;
    }
}