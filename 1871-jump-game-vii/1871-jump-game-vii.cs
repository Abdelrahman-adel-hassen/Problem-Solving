public class Solution {
    public bool Solve(int i, int minJump, int maxJump, string s, List<int> zeros)
{
    if (i >= s.Length - 1)
        return i == s.Length - 1;
    var maxStep = Math.Min(s.Length - 1, i + maxJump);
    while (zeros.Count > 0)
    {
        var step = LowerBound(zeros, i + minJump);
        if (step == -1 || step > maxStep)
            break;
        zeros.Remove(step);
        if (Solve(step, minJump, maxJump, s, zeros))
            return true;
    }
    return false;
}
public bool CanReach(string s, int minJump, int maxJump)
{
    var zeros = new List<int>();

    for (int i = 1; i < s.Length; i++)
        if (s[i] == '0')
            zeros.Add(i);
    return Solve(0, minJump, maxJump, s, zeros);
}
public  int LowerBound(List<int> sortedList, int target)
{
    int left = 0;
    int right = sortedList.Count - 1;

    while (left < right)
    {
        int mid = (left + right) / 2;

        if (sortedList[mid] < target)
            left = mid + 1;
        else
            right = mid;
    }
    return sortedList[right] < target ? -1 : sortedList[right];
}
}