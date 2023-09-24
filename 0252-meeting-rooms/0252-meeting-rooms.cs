public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
     var sorted = intervals.OrderBy(x => x[0]).ToList();
    for (int i = 0; i < sorted.Count(); i++)
    {
        if (i + 1 < sorted.Count && sorted[i][1] < sorted[i + 1][0])
            continue;

        if (i + 1 < sorted.Count && sorted[i][0] <= sorted[i + 1][0] && sorted[i +1][0] < sorted[i][1])
            return false;
    }

    return true;
    }
}