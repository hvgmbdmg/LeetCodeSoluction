public class Solution {
    
    private static String[] LESS_THAN_20 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private static String[] TENS = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    private static String[] THOUSANDS = { "", "Thousand", "Million", "Billion" };
    
    public string NumberToWords(int num) {
        if( num==0 )
            return "Zero";
        
        int whichThousands = 0;
        string result = "";
        
        while( num>0 ){
            
            if( num%1000 != 0 ){
                string temp = "";
                int partNumber = num%1000;
                
                while( partNumber>0 ){
                    if( partNumber==0 )
                        break;
                    if( partNumber<20 ){
                        temp += LESS_THAN_20[partNumber] + " ";
                        break;
                    }
                    
                    if( partNumber<100 ){
                        temp += TENS[partNumber / 10] + " ";
                        partNumber %= 10;
                        continue;
                    }
                    else{
                        temp += LESS_THAN_20[partNumber / 100] + " Hundred ";
                        partNumber %= 100;
                    }
                }//while end;
                result = temp + THOUSANDS[whichThousands] + " " + result;
            }
            
            num /= 1000;
            whichThousands ++;
        }
        
        
        return result.Trim();
    }
}