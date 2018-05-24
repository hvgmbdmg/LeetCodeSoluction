public class Solution {
    public bool IsValidSudoku(char[,] board) {
        //Genius StefanPochmann
        HashSet<string> boardContain = new HashSet<string>();
        
        for ( int row=0; row<9; row++ ) {
            for ( int column=0; column<9; column++ ) {
                if( board[row,column] != '.' )
                    if( !boardContain.Add( ("Row"+row+board[row,column]) ) ||
                        !boardContain.Add( ("Col"+column+board[row,column]) ) ||
                        !boardContain.Add( ("board"+((int)row/3)+((int)column/3)+board[row,column]) ) )
                    return false;
            }
        }
        return true;
    }
}