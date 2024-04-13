public class Solution {
    public bool EqualFrequency(string word) {
        Dictionary<char,int>frequencyNumber=new Dictionary<char,int>();
        int maxFrequencyNumber=0,minFrequencyNumber=101;
        int op1=0,op2=0;
        foreach(char ch in word)
        {
            if(!frequencyNumber.ContainsKey(ch))
                frequencyNumber[ch]=0;
            frequencyNumber[ch]++;
           maxFrequencyNumber=Math.Max(maxFrequencyNumber,frequencyNumber[ch]);

        }
      
        foreach(var frequencyNumberKeyValue in frequencyNumber)
        {
            if(frequencyNumberKeyValue.Value==maxFrequencyNumber-1)
                op1++;
             if(frequencyNumberKeyValue.Value==maxFrequencyNumber)
                op2++;
            minFrequencyNumber=Math.Min(minFrequencyNumber,frequencyNumberKeyValue.Value);

        }
        return (minFrequencyNumber==1&&maxFrequencyNumber==1)||(minFrequencyNumber==1&&op2==frequencyNumber.Count()-1)||(op1==frequencyNumber.Count()-1);
    }
}