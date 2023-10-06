public class Solution {
    public string ReverseWords(string s) {
       
        s=s.Trim();
        int n=s.Length;
        StringBuilder str=new StringBuilder(s);
        StringBuilder res=new StringBuilder();
        str=Reverse(0,n-1,str);
        str.Append(' ');
        int prevIndex=0;
        for(int i=0;i<=n;i++){
            if(i>0&&str[i]==' '&&str[i]==str[i-1]){
               continue;
            }
            if(str[i]==' '){
                res=Reverse(prevIndex,res.Length-1,res);
                prevIndex=res.Length+1;
            }
            if(i!=n)
             res.Append(str[i]);
        }
        return res.ToString();
    }
    private StringBuilder Reverse(int start,int end,StringBuilder s){
      while(end>start){
          char temp=s[start];
          s[start]=s[end];
          s[end]=temp;
          end--;
          start++;
          
      }
        return s;
    }
}