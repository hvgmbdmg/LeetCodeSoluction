public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //Try again.
        int returnLen = 0;
        int intArrLen = nums.Length-1;
        
        while( returnLen <= intArrLen ){
            if( nums[returnLen] == val )
                nums[returnLen] = nums[intArrLen--];
            else
                returnLen++;
        }

        return returnLen;
    }
}