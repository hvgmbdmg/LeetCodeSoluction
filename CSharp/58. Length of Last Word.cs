public class Solution {
    public int LengthOfLastWord(string s) {
        int Len = 0;
        for( int i=s.Length-1;i>=0;i-- ){
            if( s[i]!=' ' )
                Len++;
            else
                if( Len!=0 )
                    break;
        }
        return Len;
    }
}