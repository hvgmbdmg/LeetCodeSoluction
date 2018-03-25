public class Solution {
    public int AddDigits(int num) {
        int temp = num%9;
        return temp==0 && num!=0 ? 9: temp;
    }
}