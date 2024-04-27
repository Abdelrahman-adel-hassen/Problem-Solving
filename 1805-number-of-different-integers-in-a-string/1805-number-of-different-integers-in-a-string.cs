public class Solution {
    public int NumDifferentIntegers(string word) {
        var repeatedNumber=new Dictionary<string,bool>();
        string currentWord="";
        for(int i=0;i<=word.Count();i++){
            if(i!=word.Count()&&Char.IsNumber(word[i])){
                if(currentWord.Count()==1&&currentWord[0]=='0')
                    currentWord="";
                currentWord+=word[i];
            }
                
            else{
                if(!string.IsNullOrEmpty(currentWord))
                   repeatedNumber[currentWord]=true;
                
                    
                currentWord="";
            }
        }
        return repeatedNumber.Count();
    }
}