public class Solution {
    public bool IsBoomerang(int[][] points) {
        (int x,int y) firstPoint=(points[0][0],points[0][1]);
        (int x,int y) secondPoint=(points[1][0],points[1][1]);
        (int x,int y) thirdPoint=(points[2][0],points[2][1]);
        Console.WriteLine(secondPoint.x+" "+secondPoint.y);
        return !IsStraightLine(firstPoint.x,firstPoint.y,secondPoint.x,secondPoint.y,thirdPoint.x,thirdPoint.y);
    }
   private bool IsStraightLine(int x1, int y1, int x2, int y2, int x3, int y3) {
  return (y1 - y2) * (x1 - x3) == (y1 - y3) * (x1 - x2);
}
}