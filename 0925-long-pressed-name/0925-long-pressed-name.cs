public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        int typedLength=typed.Length,nameLength=name.Length;
        if(typedLength<nameLength)
            return false;
        if(typed==name)
            return true;
        int nameCurrentIndex=0,typedCurrentIndex=0;
        int numberOfNameCurrentCharcters=0;
        int numberOfTypedCurrentCharcters=0;
        while(nameCurrentIndex<nameLength&&typedCurrentIndex<typedLength){
           if(name[nameCurrentIndex]!=typed[typedCurrentIndex])
               return false;
            numberOfNameCurrentCharcters=0;
            numberOfTypedCurrentCharcters=0;
            nameCurrentIndex++;
            typedCurrentIndex++;
            while(nameCurrentIndex<nameLength&&name[nameCurrentIndex]==name[nameCurrentIndex-1]){
                nameCurrentIndex++;
                numberOfNameCurrentCharcters++;
            }
            while(typedCurrentIndex<typedLength&&typed[typedCurrentIndex]==typed[typedCurrentIndex-1]){
                typedCurrentIndex++;
                numberOfTypedCurrentCharcters++;
            }
            if(numberOfNameCurrentCharcters>numberOfTypedCurrentCharcters)
                return false;
        }
        return nameCurrentIndex==nameLength&&typedCurrentIndex==typedLength;
    }
}