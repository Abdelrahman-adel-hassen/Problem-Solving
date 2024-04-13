public class Solution {
    public int DistMoney(int money, int children) {
        //divide money/children ==0 return false;
        //divide money/8 >children return children-1;
        //divide money/8 <children return money/8-1;
        if(money/children==0)
            return -1;
        int answer=0;
        while(children>1&&((money-8)/(children-1))>0){
            money-=8;
            children--;
            answer++;
        }
        if(children==1&&money==8)
             answer++;
        if(children==1&&money==4)
             answer--;
        return answer;
    }
}