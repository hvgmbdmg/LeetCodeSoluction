public class Solution {
    public void Rotate(int[,] matrix) {
        //Math
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        
        for( int x=0; x<row; x++ )
            for( int y=x+1; y<column; y++ )
                Swap( ref matrix[x,y], ref matrix[y,x] );
        
        for( int x=0; x<row; x++ )
            for( int y=0; y<column/2; y++ )
                Swap( ref matrix[x,y], ref matrix[x,column-y-1] );

    }
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}