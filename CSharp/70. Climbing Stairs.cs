public class Solution {
    public int ClimbStairs(int n) {
        if( n==2 )
            return 2;
        if( n<=1 )
            return 1;
        
        int[] saveArr = new int[n+1];
        saveArr[0] = 1;
        saveArr[1] = 1;
        saveArr[2] = 2;
        for( int i=3; i<=n; i++ )
            saveArr[i] = saveArr[i-1] + saveArr[i-2];
        
        return saveArr[n];
    }
}