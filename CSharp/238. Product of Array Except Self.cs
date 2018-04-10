public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //Excellent Solution;
        //Try again;
        int len = nums.Length;
        int[] result = new int[len];
        
        result[0] = 1;
        for( int i=1; i<len; i++ )
            result[i] = result[i-1]*nums[i-1];
        
        int temp = 1;
        for( int i=len-1; i>=0; i-- ){
            result[i] *= temp;
            temp *= nums[i];
        }
        return result;
    }
}