public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        IList<int> result = new List<int>();
        
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        int rowhead = 0;
        int columnhead = 0;
        
        if( matrix==null || row==0 || column==0 )
            return result;
        row--;
        column--;
        
        
        while( rowhead <= row && columnhead <= column ){
            //Up
            for( int i=columnhead; i<=column; i++ )
                result.Add( matrix[rowhead,i] );
            rowhead++;
            
            //Right
            for( int i=rowhead; i<=row; i++ ) 
                result.Add( matrix[i,column] );
            column--;

            if( rowhead > row || columnhead > column )
                break;
            
            //Down
            for( int i=column; i>=columnhead; i-- ) 
                result.Add( matrix[row,i] );
            row--;
        
            //Left
            for( int i=row; i>=rowhead; i-- ) 
                result.Add( matrix[i,columnhead] );
            columnhead++;
        }

        return result;
    }
}