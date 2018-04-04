public class Solution {
    public int Rob(int[] nums) {
        /*
        * f(0) = 0, f(1) = nums[1];
        * f(n) = max( f(n-2)+nums[n] , f(n-1) );
        */
        
        int len = nums.Length;
        if( len == 1 )
            return nums[0];
        if( len == 0 )
            return 0;
        
        int max = 0;
        int addCurrent = 0;//f(n-2)
        int noCurrent = nums[0];//f(n-1)
        
        for( int i=1; i<nums.Length; i++ ){
            max = Math.Max( noCurrent, addCurrent+nums[i]);
            addCurrent = noCurrent;
            noCurrent = max;
        }
        return max;
    }
}