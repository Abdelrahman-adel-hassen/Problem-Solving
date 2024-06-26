public class Solution {
    public int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f) {
        if(a==e)
                return c==a&&((d>b&&d<f)||(d<b&&d>f))==true?2:1;
        else if(b==f)
                return b==d&&((c>a&&c<e)||(c<a&&c>e))==true?2:1;  
        else if(c-d==e-f)     
                    return c-d==a-b&&((e>c&&e>a&&a>c)||(e<c&&e<a&&a<c))==true?2:1;
        else if(c+d==e+f)
            return c+d==a+b&&((e>c&&e>a&&a>c)||(e<c&&e<a&&a<c))==true?2:1;
        return 2;
    }
}