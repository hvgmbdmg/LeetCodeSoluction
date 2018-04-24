public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> mySet = new HashSet<int>();
        int len = nums.Length;
        int sum = 0;
        int onceSum = 0;
        for( int i=0; i<len; i++ ){
            mySet.Add( nums[i] );
            sum += nums[i];
        }
        
        foreach( int item in mySet )
            onceSum += item;
        
        return onceSum*2-sum;
    }
}