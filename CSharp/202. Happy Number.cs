public class Solution {
    public bool IsHappy(int n) {
        //0-9;
        int[] table = new int[]{0, 1, 4, 9, 16, 25, 36, 49, 64, 81};
        List<int> intArray = new List<int>();
        int sum = 0;
        
        while( sum!=1 ){
            sum = 0;
            while( n>0 ){
                sum += table[n%10];
                n /= 10;
            }
            n = sum;
            if( intArray.IndexOf(n)!=-1 )
                return false;
            intArray.Add(n);
            //Console.WriteLine(sum);
        }
        
        return true;
    }
}