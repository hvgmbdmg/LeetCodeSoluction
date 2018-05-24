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
    public int MaxDepth(TreeNode root) {
        
        return findDepth( root, 0 );
    }
    
    int findDepth( TreeNode root, int depth ){
        if( root==null )
            return depth;
        
        //int depthR = findDepth( root.right, depth+1 );
        //int depthL = findDepth( root.left, depth+1 );
        
        return Math.Max(depth, Math.Max(findDepth( root.right, depth+1 ), findDepth( root.left, depth+1 )));
    }
}