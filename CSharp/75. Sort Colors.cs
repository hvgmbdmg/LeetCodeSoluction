public class Solution {
    public void SortColors(int[] nums) {
        int len = nums.Length-1;
        int zero = 0;
        
        for( int i=0; i<=len; i++ ){
            while( nums[i] == 2 && i<len )
                Swap( ref nums[i], ref nums[len--] );
            while( nums[i] == 0 && i>zero )
                Swap( ref nums[i], ref nums[zero++] );
        }
    }
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}