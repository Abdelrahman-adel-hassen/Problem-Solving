public class Solution {
    public string IntToRoman(int num) {
        var RomanValues=new List<(char Name,int Index)>()
     {
         ('M',1000),
         ('D',500),
         ('C',100),
         ('L',50),
         ('X',10),
         ('V',5),
         ('I',1),
     };
      var RomanConcatValues=new List<(int Index, string Name)>(){
            (900,"CM"),
            (400,"CD"),
            (90,"XC"),
            (40,"XL"),
            (9,"IX"),
            (4,"IV"),
            (1,"I"),
        };
        int RomanValuesIndex=0;
        int RomanConcatValuesIndex=0;
        StringBuilder str=new StringBuilder();
        while(num>0){
            var firstValue=RomanValues[RomanValuesIndex];
            var secondValue=RomanConcatValues[RomanConcatValuesIndex];
            if(secondValue.Index>firstValue.Index){
              int retryCount=num/secondValue.Index;
              num%=secondValue.Index;
              while(retryCount-->0)
                  str.Append(secondValue.Name);
              RomanConcatValuesIndex++;
            }
            else {
               int retryCount=num/firstValue.Index;
              num%=firstValue.Index;
              while(retryCount-->0)
                  str.Append(firstValue.Name);
              RomanValuesIndex++;
                
            }
           
        }
        return str.ToString();
    }
}