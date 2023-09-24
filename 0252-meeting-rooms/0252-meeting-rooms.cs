public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
        for(int i=1;i<intervals.GetLength(0);i++){
            if(intervals[i][0]<intervals[i-1][1])
                return false;
        }
        return true;
    }
}