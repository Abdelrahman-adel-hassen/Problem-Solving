public class Solution {
    public string RemoveDigit(string number, char digit) {
           short digitNumber = (short)(digit - '0');
           int n = number.Length;
           int removeIndex = -1;
           for (int i = 0; i < n; i++)
           {
               short currentDigit = (short)(number[i] - '0');
               if (currentDigit == digitNumber)
               {
                   removeIndex = i;

                   if (i == n - 1)
                       break;

                   short nextDigit = (short)(number[i + 1] - '0');
                   if (nextDigit > currentDigit)
                       break;
               }

           }
           number=number.Remove(removeIndex,1);
           return number;
    }
}