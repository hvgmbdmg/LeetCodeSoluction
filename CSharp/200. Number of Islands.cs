public class Solution {
    public int NumIslands(char[,] grid) {
        int row = grid.GetLength(0);
        int column = grid.GetLength(1);
        int sum = 0;

        for( int x=0;x<row;x++ ){
            for( int y=0; y<column ;y++ ){
                if( grid[x, y]=='1' ){
                    DFS( grid, row, column, x, y );
                    sum++;
                }
            }
        }
        return sum;
    }
    
    private void DFS( char[,] grid, int row, int column, int currX, int currY ){
        if( currX<0 || currY<0 || currX>row-1 || currY>column-1 || grid[currX, currY]=='0')
            return;
        grid[currX, currY] = '0';
        DFS( grid, row, column, currX+1, currY );
        DFS( grid, row, column, currX-1, currY );
        DFS( grid, row, column, currX, currY+1 );
        DFS( grid, row, column, currX, currY-1 );
    }
}