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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        while( (root.val-p.val)*(root.val-q.val)>0 ){
            if( root.val > p.val )
                root = root.left;
            else
                root = root.right;
        }

        return root;
    }
}