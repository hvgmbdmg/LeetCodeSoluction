public class Solution {
    public string AddBinary(string a, string b) {
        int aIndex = a.Length-1;
        int bIndex = b.Length-1;
        
        string returnStr = "";
        int temp = 0;
        int isAdd = 0;
        while( aIndex>=0 || bIndex>=0 ){
            temp = isAdd;
            if( aIndex>=0 )
                temp += (int)Char.GetNumericValue(a[aIndex]);
            if( bIndex>=0 )
                temp += (int)Char.GetNumericValue(b[bIndex]);

            if( temp >= 2 ){
                isAdd = 1;
                temp -= 2;
                returnStr = returnStr + Convert.ToString(temp);
            }
            else{
                isAdd = 0;
                returnStr += Convert.ToString(temp);
            }
            aIndex--;
            bIndex--;
            //Console.WriteLine(returnStr);
        }
        if( isAdd==1 )
            returnStr += "1";
        
        char[] charArray = returnStr.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
}