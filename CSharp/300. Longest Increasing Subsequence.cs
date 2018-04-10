public class Solution {
    public int LengthOfLIS(int[] nums) {
        //Try again;
        int len = nums.Length;
        int[] result = new int[len];
        if( len==0 )
            return 0;
        
        for( int i=0; i<len; i++ )
            result[i] = 1;

        for( int i=1; i<len; i++ ){
            for( int l=0; l<i; l++ ){
                if( nums[i]>nums[l] )
                    result[i] = Math.Max( result[l]+1,result[i] );
            }
        }
        return result.Max();

    }
}