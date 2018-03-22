public class Solution {
    public int Reverse(int x) {
        int tempX = 0;
        int newRes = 0;
        
        while( x!=0 ){
            tempX = tempX*10 + x%10;
            if( newRes != (tempX-x%10)/10 )
                return 0;
            newRes = tempX;
            x /= 10;
        }

        return tempX;
    }
}