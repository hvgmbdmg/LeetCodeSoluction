public class Solution {
    public int TitleToNumber(string s) {
        int n = 0;
        for(int i=0;i<s.Length;i++){
            n *= 26;
            n += (s[i]-'A'+1);
        }
        return n;
    }
}