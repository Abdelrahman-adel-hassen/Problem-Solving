public class Solution {
    public int DistMoney(int money, int children) {
        //divide money/children ==0 return false;
        //divide money/8 >children return children-1;
        //divide money/8 <children return money/8-1;
        money -= children;
        if (money < 0)
            return -1;
        bool isNoMoreExist=money % 7 == 0;
        if (money / 7 == children && isNoMoreExist)
            return children;
        if (money / 7 == children - 1 && money % 7 == 3)
            return children - 2;
         if (money / 7 >= children - 1)
            return children - 1;
        return  money / 7;
    }
}