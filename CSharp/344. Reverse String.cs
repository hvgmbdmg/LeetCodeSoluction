public class Solution {
    public string ReverseString(string s) {
        char[] s1 = s.ToCharArray();
        char temp;
        int head = 0;
        int end = s.Length-1;
        
        while( head<end ){
            temp = s1[end];
            s1[end] = s1[head];
            s1[head] = temp;
            
            head++;
            end--;
        }

        return new string(s1);
    }
}