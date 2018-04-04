public class Solution {
    public int Rob(int[] nums) {
        /*
        * f(0) = 0, f(1) = nums[1];
        * f(n) = max( f(n-2)+nums[n] , f(n-1) );
        * 
        * find max( f(0~n-1), f(1~n) )
        */
        
        int len = nums.Length;
        if( len == 2 )
            return Math.Max(nums[0], nums[1]);
        if( len == 1 )
            return nums[0];
        if( len == 0 )
            return 0;
        
        int max = 0;
        int preMax = 0;
        int addCurrent = 0;//f(n-2)
        int noCurrent = nums[0];//f(n-1)
        
        for( int i=1; i<nums.Length-1; i++ ){
            max = Math.Max( noCurrent, addCurrent+nums[i]);
            addCurrent = noCurrent;
            noCurrent = max;
        }//Can contain first poistion.
        preMax = max;
        max = 0;
        addCurrent = 0;
        noCurrent = nums[1];
        for( int i=2; i<nums.Length; i++ ){
            max = Math.Max( noCurrent, addCurrent+nums[i]);
            addCurrent = noCurrent;
            noCurrent = max;
        }//Can't contain first poistion.
        

        return Math.Max(max, preMax);
    }
}