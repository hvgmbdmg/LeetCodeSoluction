public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>();
        string[] mapper = new string[10] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        int len = digits.Length;

        result.Add("");
        for( int i=0; i<len; i++ ){
            int temp = digits[i]-'0';
            if( temp < 2 )
                continue;
            int subLen = mapper[temp].Length;
            int tempLen = result.Count;
            for( int j=0; j<tempLen; j++ ){
                string newStr = result[0];
                for( int l=0; l<subLen; l++ ){
                    result.Add( newStr+mapper[temp][l] );
                }
                result.RemoveAt(0);
            }
        }
        if( result[0]=="" )
            result.RemoveAt(0);

        return result;
    }
}