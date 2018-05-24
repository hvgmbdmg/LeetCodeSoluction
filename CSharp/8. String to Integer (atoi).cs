public class Solution {
    public int MyAtoi(string str) {
        bool isPositive = true;
        int index = 0;
        int len = str.Length;
        int result = 0;
        
        while( index < len && str[index]==' ' ){
            index++;
        }
        if( index < len && (str[index] == '-' || str[index] == '+') ){
            if( str[index] == '-' )
                isPositive = false;
            index++;
        }
        while( index < len && str[index] >= '0' && str[index] <= '9' ){
            if( result>Int32.MaxValue/10 || Int32.MaxValue-result*10<str[index]-'0' ){
                if( isPositive )
                    return Int32.MaxValue;
                else
                    return Int32.MinValue;
            }
            result = result*10 + (str[index]-'0');
            index++;
        }
        
        return isPositive ? result : -result;
    }
}