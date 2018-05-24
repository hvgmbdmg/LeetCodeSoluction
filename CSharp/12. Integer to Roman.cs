public class Solution {
    public string IntToRoman(int num) {
        string[] Thousand = new string[4]{ "", "M", "MM", "MMM" };
        string[] Hundred = new string[10]{ "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] Ten = new string[10]{ "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] One = new string[10]{ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        return Thousand[num/1000]+Hundred[(num/100)%10]+Ten[(num/10)%10]+One[num%10];
    }
}