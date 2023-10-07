public class Solution {
    public string IntToRoman(int num) {

      var RomanValues=new List<(int Value, string Name)>(){
            (1000,"M"),
            (900,"CM"),
            (500,"D"),
            (400,"CD"),
            (100,"C"),
            (90,"XC"),
            (50,"L"),
            (40,"XL"),
            (10,"X"),
            (9,"IX"),
            (5,"V"),
            (4,"IV"),
            (1,"I"),
        };
        int RomanValuesIndex=0;
        StringBuilder str=new StringBuilder();
        while(num>0){
            var RomanValue=RomanValues[RomanValuesIndex];
              while(num>=RomanValue.Value){
                  num-=RomanValue.Value;
                  str.Append(RomanValue.Name);
              }
              RomanValuesIndex++;
                
        }
        return str.ToString();
    }
}