class Solution {
public:
    bool hasGroupsSizeX(vector<int>& deck) {
        
        int n=deck.size(),c=1,g=0;
        if(n==1)return 0;
        sort(deck.begin(),deck.end());
        for(int i=1;i<n;i++){
            if(deck[i]==deck[i-1])c++;
            else {
               g=__gcd(g,c);
                c=1;
               
            }
        }
        //cout<<c<<" "<<g<<endl;
             g=__gcd(g,c);
    
        return g!=1;
    }
};