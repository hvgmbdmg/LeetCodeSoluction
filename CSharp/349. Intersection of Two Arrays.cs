public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        //Try hashSet;
        HashSet<int> interestionNumbers = new HashSet<int>();
        List<int> result = new List<int>();
        
        //int len = nums1.Length>nums2.Length ? nums1.Length : nums2.Length;
        for( int i=0; i<nums1.Length; i++ )
            interestionNumbers.Add( nums1[i] );
        
        for( int i=0; i<nums2.Length; i++ ){
            if( interestionNumbers.Contains( nums2[i] ) ){
                interestionNumbers.Remove( nums2[i] );
                result.Add( nums2[i] );
            }
        }
        
        return result.ToArray();
    }
}