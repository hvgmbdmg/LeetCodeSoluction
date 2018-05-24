/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int FindSecondMinimumValue(TreeNode root) {
        HashSet<int> uniqueSet = new HashSet<int>();
        Travel( root, uniqueSet );
        if( uniqueSet.Count<2 )
            return -1;
        uniqueSet.Remove( uniqueSet.Min() );
        return uniqueSet.Min();
    }

    public void Travel( TreeNode root, HashSet<int> uniqueSet ){
        if( root != null ){
            uniqueSet.Add( root.val );
            Travel( root.left, uniqueSet );
            Travel( root.right, uniqueSet );
        }
    }
}