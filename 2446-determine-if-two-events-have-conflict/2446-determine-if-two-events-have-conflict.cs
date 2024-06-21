public class Solution {
public  bool HaveConflict(string[] event1, string[] event2)
{
    var event1Start = event1[0].Split(':').Select(x => int.Parse(x)).ToList();
    var event1End = event1[1].Split(':').Select(x => int.Parse(x)).ToList();
    var event2Start = event2[0].Split(':').Select(x => int.Parse(x)).ToList();
    var event2End = event2[1].Split(':').Select(x => int.Parse(x)).ToList();
    var event1StartTime = event1Start[0] * 60 + event1Start[1];
    var event1EndTime = event1End[0] * 60 + event1End[1];
    var event2StartTime = event2Start[0] * 60 + event2Start[1];
    var event2EndTime = event2End[0] * 60 + event2End[1];
    return IsIntersect(event1StartTime,event1EndTime, event2StartTime, event2EndTime);
}
private bool IsIntersect(int event1StartTime,int event1EndTime, int event2StartTime, int event2EndTime)
{
    return event1StartTime <= event2EndTime && event1EndTime >= event2StartTime;
}
}