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
    public int ClosestValue(TreeNode root, double target) {
        int result = root.val;
        
        while( root!=null ){
            if( Math.Abs(target-root.val) < Math.Abs( target-result ) )
                result = root.val;

            if( root.val > target )
                root = root.left;
            else
                root = root.right;
        }
        
        return result;
    }
}