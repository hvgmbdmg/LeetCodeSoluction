public class Solution {
    public int CountBattleships(char[,] board) {
        int row = board.GetLength(0);
        int column = board.GetLength(1);
        int count = 0;
        
        for( int i=0;i<row;i++ ){
            for( int l=0;l<column;l++ ){
                if( board[i,l]=='.' )
                    continue;
                if( i>0 && board[i-1,l]=='X' )
                    continue;
                if( l>0 && board[i,l-1]=='X' )
                    continue;
                count++;
            }
        }
        
        return count;
    }
}