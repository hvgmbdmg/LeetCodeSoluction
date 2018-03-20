class Solution {
public:
    bool isPalindrome(int x) {
        if( x<0 )
            return false;
        
        int originalX = x;
        int reverseX = 0;
        int tempX = 0;
        
        while( x!=0 ){
            reverseX = reverseX*10 + x%10;
            if( (reverseX-x%10)/10!=tempX )
                return false;
            tempX = reverseX;
            x/=10;
        }
        
        if( reverseX == originalX )
            return true;
        return false;
    }
};


//better solution
/*
class Solution {
public:
    bool isPalindrome(int x) {
        if(x<0|| (x!=0 &&x%10==0)) return false;
        int sum=0;
        while(x>sum)
        {
            sum = sum*10+x%10;
            x = x/10;
        }
        return (x==sum)||(x==sum/10);
    }
};
*/