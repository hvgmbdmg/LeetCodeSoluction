public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        int len = nums.Length;
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums); 

        for( int i=0; i<len-2; i++ ){
            if( i==0 || (i>0 && nums[i]!=nums[i-1])){ //[-1,-1,-1,2]
                int left = i+1;
                int right = len-1;
                int sum = 0-nums[i];
                while( left<right ){
                    if( nums[left]+nums[right] == sum ){
                        int[] temp = { nums[i] ,nums[left], nums[right] };
                        result.Add(new List<int>(temp));
                        while( left<right && nums[left]==nums[left+1] )
                            left++;
                        while( left<right && nums[right]==nums[right-1] )
                            right--;
                        left++;
                        right--;
                    }
                    else
                        if( nums[left]+nums[right] > sum )
                            right--;
                        else
                            left++;
                }
            }
        }
        
        return result;
    }
}