public class Solution {
    public int MySqrt(int x) {
        //return (int)Math.Sqrt(x);
        //Stupid, Try again
        int n = 1;
        int last = 0;
        int now = n*n;
        while( now <= x ){
            n++;
            now = n*n;
            if( now<last )
                return --n;
            last = now;
        }
        
        return --n;
    }
}