public class Solution {
    public bool IsValid(string s) {
        //try use stack next time
        int i=0;
        while( s!="" ){
            char temp = s[i];
            switch( temp ){
                case '(':
                    i++;
                    break;
                    
                case ')':
                    if( i>0 && s[i-1]=='(' )
                        s = s.Remove( --i, 2);
                    else
                        return false;
                    break;
                case '[':
                    i++;
                    break;
                case ']':
                    if( i>0 && s[i-1]=='[' )
                        s = s.Remove( --i, 2);
                    else
                        return false;
                    break;
                case '{':
                    i++;
                    break;
                case '}':
                    if( i>0 && s[i-1]=='{' )
                        s = s.Remove( --i, 2);
                    else
                        return false;
                    break;
            }
            if(i+1>s.Length && s!="")
                return false;
            
        }
        return true;
        
    }
}