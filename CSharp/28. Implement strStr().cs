public class Solution {
    public int StrStr(string haystack, string needle) {
        /*
        It's ok, but too easy.
        return haystack.IndexOf( needle );
        */
        //Stupid answer
        int returnAns = -1;
        bool same = true;
        for( int i=0; i<haystack.Length-needle.Length+1; i++ ){
            same = true;
            for( int l=0; l<needle.Length; l++ ){
                if( haystack[i+l]!=needle[l] ){
                    same = false;
                    break;
                }
            }
            if( same ){
                returnAns = i;
                break;
            }
        }
        
        return returnAns;
    }
}