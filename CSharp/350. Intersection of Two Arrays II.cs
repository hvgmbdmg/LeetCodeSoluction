public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Hashtable hashTable = new Hashtable();
        List<int> result = new List<int>();
        
        for( int i=0; i<nums1.Length; i++ ){
            if( hashTable.Contains( nums1[i] ) )
                hashTable[ nums1[i] ] = (int)hashTable[nums1[i]] + 1;
            else
                hashTable.Add( nums1[i], 1 );
        }

        for( int i=0; i<nums2.Length; i++ ){
            if( hashTable.Contains( nums2[i] ) ){
                int count = (int)hashTable[nums2[i]] - 1;
                result.Add( nums2[i] );
                if( count == 0 )
                    hashTable.Remove( nums2[i] );
                else
                    hashTable[ nums2[i] ] = count;
            }
        }
        
        return result.ToArray();
    }
}