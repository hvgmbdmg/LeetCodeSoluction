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
        
        if( root == p || root == q || root == null )
            return root;
        TreeNode leftNode = LowestCommonAncestor(root.left,p,q);
        TreeNode rightNode = LowestCommonAncestor(root.right,p,q);
        
        if( leftNode==null )
            return rightNode;
        if( rightNode==null )
            return leftNode;
        return root;
        
    }
}