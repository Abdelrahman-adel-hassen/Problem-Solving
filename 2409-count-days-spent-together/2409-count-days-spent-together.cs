public class Solution {
    
//string arriveAlice = "10-01", leaveAlice = "10-31", arriveBob = "11-01", leaveBob = "12-31";
//Console.WriteLine(CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob));
public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
{
    int[] months = { 0,31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    (int month, int day) calenderArriveAlice = GetCalender(arriveAlice);
    (int month, int day) calenderArriveBoob = GetCalender(arriveBob);
    (int month, int day) calenderLeaveAlice = GetCalender(leaveAlice);
    (int month, int day) calenderLeaveBoob = GetCalender(leaveBob);
    (int month, int day) overleapArrive = (calenderArriveBoob.month, calenderArriveBoob.day);
    (int month, int day) overleapLeave = (calenderLeaveBoob.month, calenderLeaveBoob.day);

    if (calenderArriveAlice.month == calenderArriveBoob.month)
        overleapArrive = (calenderArriveBoob.month, Math.Max(calenderArriveAlice.day, calenderArriveBoob.day));
    else if (calenderArriveAlice.month > calenderArriveBoob.month)
        overleapArrive = (calenderArriveAlice.month, calenderArriveAlice.day);

    if (calenderLeaveAlice.month == calenderLeaveBoob.month)
        overleapLeave = (calenderLeaveBoob.month, Math.Min(calenderLeaveAlice.day, calenderLeaveBoob.day));
    else if (calenderLeaveAlice.month < calenderLeaveBoob.month)
        overleapLeave = (calenderLeaveAlice.month, calenderLeaveAlice.day);

    return GetDaysOverLap(overleapArrive, overleapLeave, months);
}

(int month, int day) GetCalender(string celender)
{
    var arrival = celender.Split('-').Select(x => int.Parse(x)).ToList();
    (int month, int day) arrivalCalender = (arrival[0], arrival[1]);
    return arrivalCalender;
}

int GetDaysOverLap((int month, int day) calenderArrive, (int month, int day) calenderLeave, int[] months)
{
    if (calenderLeave.month < calenderArrive.month)
        return 0;
    if (calenderLeave.day < calenderArrive.day && calenderLeave.month == calenderArrive.month)
        return 0;
    if (calenderLeave.month == calenderArrive.month)
        return calenderLeave.day - calenderArrive.day + 1;
    int days = months[calenderArrive.month] - calenderArrive.day+1 ;
    calenderArrive.month++;
    while (calenderArrive.month < calenderLeave.month)
    {
        days += months[calenderArrive.month];
        calenderArrive.month++;
    }

    return calenderLeave.day + days;
}

}