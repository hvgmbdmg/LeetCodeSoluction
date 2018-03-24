public class Solution {
    public int SearchInsert(int[] nums, int target) {
        //Binary Search;
        //Try again;
        int head = 0;
        int tail = nums.Length-1;

        while( tail >= head ){
            int mid = (tail+head)/2;
            
            if( target > nums[mid] )
                head = mid+1;
            else
                tail = mid-1;                
        }
        return head;
    }
}