public class Solution {
    public int[][] SortTheStudents(int[][] score, int k) {
        Array.Sort(score, (a, b) => b[k].CompareTo(a[k]));
        return score;
    }
}