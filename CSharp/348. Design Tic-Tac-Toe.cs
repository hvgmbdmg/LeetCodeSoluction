public class TicTacToe {
    private int[,] board;
    private int N;

    /** Initialize your data structure here. */
    public TicTacToe(int n) {
        board = new int[n, n];
        N = n;
        int c=0;
        
        for( int i=0;i<n;i++ ){
            for( int l=0;l<n;l++ ){
                board[i, l] = 0;
            }
        }

    }
    
    /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
    public int Move(int row, int col, int player) {
        
        //Some Error;
        if( board[row,col]!=0 )
            return 0;
        
        board[row,col] = player;
        int tempPlayer = player;
        int winCondition = 0;
        for( int i=0;i<N;i++ ){
            if( board[row,i]==tempPlayer )
                winCondition++;
        }
        if( winCondition==N )
            return tempPlayer;
        else
            winCondition = 0;
        
        
        for( int i=0;i<N;i++ ){
            if( board[i,col]==tempPlayer )
                winCondition++;
        }
        if( winCondition==N )
            return tempPlayer;
        else
            winCondition = 0;
        
        for( int i=0;i<N;i++){
            if( board[i,i]==tempPlayer )
                winCondition++;
        }
        if( winCondition==N )
            return tempPlayer;
        else
            winCondition = 0;
        
        
        for( int i=0;i<N;i++){
            if( board[N-1-i,i]==tempPlayer )
                winCondition++;
        }
        if( winCondition==N )
            return tempPlayer;
        else
            winCondition = 0;

        
        return 0;
    }
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */