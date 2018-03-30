public class Solution {
    public int MissingNumber(int[] nums) {
        //Try XOR next time;
        int sum = 0;
        int n = nums.Length;
        for(int i=0;i<nums.Length;i++)
            sum += nums[i];
        return (n+1)*n/2 - sum;
    }
}