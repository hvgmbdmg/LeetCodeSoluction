public class Solution {
    public int[] PlusOne(int[] digits) {
        bool isNeedAdd = true;
        for( int i=digits.Length-1;i>=0;i-- ){
            if( isNeedAdd ){
                isNeedAdd = false;
                if( ++digits[i] >= 10 ){
                    digits[i] = 0;
                    isNeedAdd = true;
                }
            }
            else
                break;
        }
        if( isNeedAdd ){
            int[] reArr = new int[ digits.Length+1 ];
            reArr[0] = 1;
            digits.CopyTo( reArr, 1 );
            return reArr;
        }
        return digits;
    }
}