public class Solution {
    public string CountAndSay(int n) {
        //Stupid Problem, misleading description
        if( n==0 )
            return "";
        if( n==1 )
            return "1";
        
        string tempStr = "1";
        string newStr = "";
        int count = 0;
        for( int i=1; i<n; i++ ){
            newStr = "";
            count = 1;
            for( int l=1; l<=tempStr.Length; l++ ){
                if( l==tempStr.Length || tempStr[l]!=tempStr[l-1] ){
                    newStr = newStr + count + tempStr[l-1];
                    count = 1;
                }
                else
                    count++;
            }
            tempStr = newStr;
        }
        return newStr;
    }
}