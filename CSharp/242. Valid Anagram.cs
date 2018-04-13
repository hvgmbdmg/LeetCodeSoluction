public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] sChar = new int[26];
        int[] tChar = new int[26];
        
        for( int i=0; i<s.Length; i++ )
            sChar[s[i]-'a']++;
        for( int i=0; i<t.Length; i++ )
            tChar[t[i]-'a']++;
        
        for( int i=0; i<26; i++ )
            if( sChar[i]!=tChar[i] )
                return false;
        
        return true;
    }
}