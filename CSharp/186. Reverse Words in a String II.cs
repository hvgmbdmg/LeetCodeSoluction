public class Solution {
    public void ReverseWords(char[] str) {
        int strLength = str.Length;
        int lastReverse = 0;
        
        Array.Reverse( str );
        for( int i=0; i<strLength; i++ ){
            if( str[i]==' ' ){
                Array.Reverse( str, lastReverse, i-lastReverse );
                lastReverse = i+1;
            }
        }
        Array.Reverse( str, lastReverse, strLength-lastReverse );
        
        
    }
}