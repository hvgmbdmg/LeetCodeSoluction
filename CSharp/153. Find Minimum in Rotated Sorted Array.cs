public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;
        int end = nums.Length-1;
        
        while( start<end ){
            int mid = (start+end)/2;
            if( nums[mid] > nums[end] )
                start = mid+1;
            else
                end = mid;
        }

        return nums[start];
    }
}