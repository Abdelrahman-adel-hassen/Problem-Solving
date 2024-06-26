public class Solution {
    public int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f) {
        bool bishopIsBetweenQueenAndRockInColumn=(d>b&&d<f)||(d<b&&d>f);
        bool bishopIsBetweenQueenAndRockInRow=(c>a&&c<e)||(c<a&&c>e);
        bool bishopIsBetweenQueenAndRockInDiagonal1=(e>c&&e>a&&a>c)||(e<c&&e<a&&a<c);
        bool bishopIsBetweenQueenAndRockInDiagonal2=(e>c&&e>a&&a>c)||(e<c&&e<a&&a<c);
        if(a==e)
                return (c==a&&bishopIsBetweenQueenAndRockInColumn)?2:1;
        else if(b==f)
                return (b==d&&bishopIsBetweenQueenAndRockInRow)?2:1;  
        else if(c-d==e-f)     
                    return (c-d==a-b&&bishopIsBetweenQueenAndRockInDiagonal1)?2:1;
        else if(c+d==e+f)
            return (c+d==a+b&&bishopIsBetweenQueenAndRockInDiagonal2)?2:1;
        return 2;
    }
}