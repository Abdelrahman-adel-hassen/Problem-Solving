public class Solution {
    public string CategorizeBox(int length, int width, int height, int mass) {
        bool bulky = ((long)length * width * height >= 1e9) || length >= 1e4 || height >= 1e4 || width >= 1e4;
        bool heavy = mass >= 100;

        if(bulky && heavy)
            return "Both";
        else if(!bulky && ! heavy)
            return "Neither";
        else if(bulky)
            return "Bulky";
        else 
            return "Heavy";
    }
}