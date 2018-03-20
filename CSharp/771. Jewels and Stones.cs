public class Solution {
    public int NumJewelsInStones(string J, string S) {
        return S.Count( i=> J.Contains(i)!=false );
    }
}