public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //nums1 has enough space;
        //big to small

        int i = m+n-1;
        int x = m-1;
        int y = n-1;
        
        while( x>=0 && y>=0 ){
            if( nums1[x]>nums2[y] )
                nums1[i--] = nums1[x--];
            else
                nums1[i--] = nums2[y--];
        }
        while( y>=0 )
            nums1[i--] = nums2[y--];

    }
}