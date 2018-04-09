public class Solution {
    public void SetZeroes(int[,] matrix) {
        bool isColumn0 = false;
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        
        for( int i=0; i<row; i++ ){
            if( matrix[i,0]==0 )
                isColumn0 = true;
            for( int j=1; j<column; j++ )
                if( matrix[i,j]==0 ){
                    matrix[i,0] = 0;
                    matrix[0,j] = 0;
                }
        }
        
        for( int i=row-1; i>=0; i-- ){
            for( int j=column-1; j>=1; j-- )
                if( matrix[i,0]==0 || matrix[0,j]==0 )
                    matrix[i,j] = 0;

            if( isColumn0 )
                matrix[i,0] = 0;
        }
        
    }
}