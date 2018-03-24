public class Solution {
    public int MaxSubArray(int[] nums) {
        //DP
        //containing at least one number
        //if( nums.Length == 0 )
        //    return 0;
        
        int max = nums[0];
        int preMax = nums[0];

        for( int i=1; i<nums.Length ;i++ ){
            preMax = Math.Max( preMax+nums[i],nums[i] );
            max = Math.Max( max,preMax );
        }
        
        return max;
    }
}