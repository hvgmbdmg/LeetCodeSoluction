public class Solution {
    public int FindMinArrowShots(int[,] points) {
        //2D array separate to two array;
        //due to sort
        int len = points.GetLength(0);
        if( len==0 )
            return 0;
        int[] headArray = new int[ len ];
        int[] tailArray = new int[ len ];
        
        for( int i=0; i<len; i++ ){
            headArray[i] = points[i,0];
            tailArray[i] = points[i,1];
        }
        Array.Sort( tailArray, headArray );
        
        int index = tailArray[0];
        int count = 1;
        for( int i=0; i<len; i++ ){
            if( index>=headArray[i] )
                continue;
            else{
                count++;
                index = tailArray[i];
            }
        }

        return count;
    }
}