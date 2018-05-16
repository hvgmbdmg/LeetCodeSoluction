public class Solution {
    public string LongestPalindrome(string s) {
        int head = 0, tail = 0;
        int len = s.Length;
        int thisCenterMax = 0;
        for( int i=0; i<len; i++ ){
            int len1 = fixedCenterLongestPalindrome( ref s, i, i, ref len );
            int len2 = fixedCenterLongestPalindrome( ref s, i, i+1, ref len );
            thisCenterMax = Math.Max(len1,len2);
            if( thisCenterMax > tail-head ){
                head = i-(thisCenterMax-1)/2;
                tail = i+thisCenterMax/2;
            }
        }
        return s.Substring( head, tail-head+1 );
    }

    public int fixedCenterLongestPalindrome( ref string s, int left, int right, ref int len ){
        while( left>=0 && right<len && s[left]==s[right] ){
            left--;
            right++;
        }
        return right-left-1;
    }
}