public class Solution {
    public int PassThePillow(int n, int time) {
        var current=time%(n-1);
        var tot=time/(n-1);
        Console.WriteLine(tot+" "+current);
        return tot%2==0?current+1:n-current;
    }
}