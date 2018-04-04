public class Solution {
    public bool CanJump(int[] nums) {           
        int maxindex = 0;
        
        for( int i=0; i<nums.Length; i++ ){
            if( maxindex < i )
                return false;
            maxindex = Math.Max( maxindex, nums[i]+i );
        }
        return true;
    }
}