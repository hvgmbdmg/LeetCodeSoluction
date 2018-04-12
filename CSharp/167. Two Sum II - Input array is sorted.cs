public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length-1;
        int sum = Int32.MaxValue;
        
        while( sum!=target && start<=end ){
            sum = numbers[start] + numbers[end];
            
            if( sum < target )
                start++;
            if( sum > target )
                end--;
        }
        
        return new int[2]{ start+1, end+1 };
    }
}