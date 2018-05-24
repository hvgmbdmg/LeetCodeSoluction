public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> Result = new List<IList<int>>();
        int len = nums.Length;
        
        Recursive( Result, new List<int>(), nums, len );
               
        return Result;
    }
    
    public void Recursive( IList<IList<int>> result, IList<int> newList, int[] nums, int len ){
        if( newList.Count == len ){
            List<int> copy = new List<int>(newList);
            result.Add(copy);
        }
        else{
            for( int i=0; i<len; i++ ){
                if( !newList.Contains(nums[i]) ){
                    newList.Add( nums[i] );
                    Recursive( result, newList, nums, len );
                    newList.RemoveAt( newList.Count-1 );
                }
            }
        }
    }
    
}