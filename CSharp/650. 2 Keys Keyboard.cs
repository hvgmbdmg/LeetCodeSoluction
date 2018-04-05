public class Solution {
    public int MinSteps(int n) {
        //
        int result = 0;
        for( int i=2; i<=n; i++ ){
            
            while( n%i==0 ){
                result += i;
                n /= i;
            }
        }
        
        
        return result;
    }
}