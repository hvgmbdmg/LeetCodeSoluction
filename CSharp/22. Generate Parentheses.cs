public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> Result = new List<string>();
        IList<int> diff = new List<int>();
        
        Result.Add("");
        diff.Add(0);
        
        for( int i=0; i<n*2; i++ ){
            int nowLen = Result.Count;
            for( int j=0; j<nowLen; j++ ){
                if( diff[0]>0 ){
                    if( diff[0] < n*2-i ){
                        Result.Add( Result[0]+"(" );
                        diff.Add( diff[0]+1 );
                    }
                    
                    Result.Add( Result[0]+")" );
                    diff.Add( diff[0]-1 );
                    Result.RemoveAt(0);
                    diff.RemoveAt(0);
                }
                else{
                    Result.Add( Result[0]+"(" );
                    diff.Add( diff[0]+1 );
                    Result.RemoveAt(0);
                    diff.RemoveAt(0);
                }
            }
        }
        return Result;
    }
}