class Robot {
public:
    Robot(int width, int height):w(--width),h(--height),p(w+w+h+h) {}
    
    void step(int num) {
        if(num and d==4) --d; //for first move
        num%=p;
        while(num) {
            switch(d) {
                case 0:
                    if(x+num<=w) { x+=num; num=0; }
                    else { num-=w-x; x=w; d=1; }
                    break;
                case 1:
                    if(y+num<=h) { y+=num; num=0; }
                    else { num-=h-y; y=h; d=2; }
                    break;
                case 2:
                    if(x-num>=0) { x-=num; num=0; }
                    else { num-=x; x=0; d=3; }
                    break;
                case 3:
                    if(y-num>=0) { y-=num; num=0; }
                    else { num-=y; y=0; d=0; }
            };
        }
    }
    
    vector<int> getPos() {
        return {x,y};
    }
    
    string getDir() {
        switch(d) {
            case 1 : return "North";
            case 2 : return "West" ;
            case 3 : return "South";
            default: return "East" ;
        };
    }
private:
    int x=0,y=0,d=4,w,h,p;
};