public class Solution {
    public int Jump(int[] nums) {
        //You can assume that you can always reach the last index.
        int level = 0;
        int len = nums.Length;
        int maxPosition = 0;
        int lastPos = 0;
        int i = 0;
        if( len<2 )
            return 0;

        while( maxPosition<len ){
            level++;
            
            for( ;i<=lastPos; i++ ){
                if( maxPosition<nums[i]+i )
                    maxPosition = nums[i]+i; 
                
                if( maxPosition>=len-1 )
                    return level;

            }
            lastPos = maxPosition;
        }
        
        return 0;
    }
}