public class Solution {
    public int NumSquares(int n) {
        List<int> coverNumber = new List<int>();
        int biggestP = (int)Math.Sqrt(n);
        int[] psnArray = new int[biggestP+1];

        coverNumber.Add(0);
        for( int i=1; i<=biggestP; i++ ){
            psnArray[i] = i*i;
        }//ok;
        
        while( coverNumber.Count<=n ){
            int sum = Int32.MaxValue;
            int nowLength = coverNumber.Count;
            int sqr = (int)Math.Sqrt(nowLength);
            
            for (int i = 1; i <= sqr; i++)
                sum = Math.Min(sum, coverNumber[nowLength - psnArray[i]] + 1);
            coverNumber.Add(sum);
        }
        /*
        for( int i=0;i<=biggestP;i++ )
            Console.WriteLine(i+": "+psnArray[i]);
        
        for( int i=0;i<=n;i++ )
            Console.WriteLine(i+": "+coverNumber[i]);
        */
        return coverNumber[n];
    }
}