public class Solution {
    public string Convert(string s, int numRows) {
        if( numRows<2 )
            return s;
        string result = "";
        int gap = numRows*2-2;
        int index = 0;
        int len = s.Length;
        //this is 0
        while( len>index ){
            result+=s[index];
            index+=gap;
        }
        for( int i=1;i<numRows-1;i++ ){
            index = 0;
            while( true ){
                if( index+i>=len )
                    break;
                result+=s[index+i];
                index+=gap;
                if( index-i>=len )
                    break;
                result+=s[index-i];
            }

        }
        //this is numRows-1
        index = numRows-1;
        while( len>index ){
            result+=s[index];
            index+=gap;
        }
        return result;
    }
}