public class Solution {
    public int MaxProfit(int[] prices) {
        int sumProfit = 0;
        
        for( int i=0; i<prices.Length-1; i++ )
            if( prices[i+1]>prices[i] )
                sumProfit += prices[i+1] - prices[i];
        
        return sumProfit;
    }
}