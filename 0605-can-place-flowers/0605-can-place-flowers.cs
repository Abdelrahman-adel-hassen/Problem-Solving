public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int start=-1;
        int numberCanPlanned=0;
        for(int i=0;i<flowerbed.Length;i++){
            if(i==flowerbed.Length||flowerbed[i]==1){
                numberCanPlanned+=(i-start-1)/2;
                start=i+1;
            }
        }
        numberCanPlanned+=(flowerbed.Length-start)/2;
        Console.WriteLine(numberCanPlanned);
        return numberCanPlanned>=n;
    }
}