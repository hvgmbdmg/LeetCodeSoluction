public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> existSet = new HashSet<char>();
        int left = 0;
        int right = 0;
        int len = s.Length;
        int maxLength = 0;
        int nowLength = 0;

        while( right!=len ){
        	if( existSet.Contains( s[right] ) ){
        		existSet.Remove( s[left] );
        		left++;
        		nowLength--;

        	}
        	else{
        		existSet.Add( s[right] );
        		right++;
        		nowLength++;
        		if( nowLength > maxLength )
        			maxLength = nowLength;
        	}
        }
        
        return maxLength;
    }
}