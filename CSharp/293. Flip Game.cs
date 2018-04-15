public class Solution {
    public IList<string> GeneratePossibleNextMoves(string s) {
        IList<string> result = new List<string>();
        int len = s.Length;
        for( int i=0; i<len-1; i++ ){
            if( s[i]=='+' && s[i+1]=='+' )
                result.Add( s.Substring(0,i) + "--" + s.Substring(i+2,len-i-2) );
        }

        return result;
    }
}