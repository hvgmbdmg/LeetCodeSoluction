public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //bad solution.
        int onePos = 0;
        int twoPos = nums.Length-1;
        int[] sortedNums = nums.OrderBy(i => i).ToArray();
        
        while( sortedNums[onePos]+sortedNums[twoPos] != target ){
            if( sortedNums[onePos]+sortedNums[twoPos] < target )
                onePos++;
            else if( sortedNums[onePos]+sortedNums[twoPos] > target )
                twoPos--;
        }
        if( sortedNums[onePos] == sortedNums[twoPos] ){
            onePos = Array.IndexOf(nums, sortedNums[onePos]);
            twoPos = Array.IndexOf(nums, sortedNums[twoPos], onePos+1);
        }
        else{ 
            onePos = Array.IndexOf(nums, sortedNums[onePos]);
            twoPos = Array.IndexOf(nums, sortedNums[twoPos]);
        }
        if( onePos < twoPos )
            return new int[]{ onePos, twoPos };
        return new int[]{ twoPos, onePos };
    }
}