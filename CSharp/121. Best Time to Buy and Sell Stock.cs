public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int chearest;
        if( prices.Length>1 )
            chearest = prices[0];
        else
            return 0;
        
        for( int i=0;i<prices.Length;i++ ){
            if( maxProfit < prices[i]-chearest )
                maxProfit = prices[i]-chearest;
            if( prices[i] < chearest )
                chearest = prices[i];
        }

        return maxProfit<0 ? 0 : maxProfit;
    }
}