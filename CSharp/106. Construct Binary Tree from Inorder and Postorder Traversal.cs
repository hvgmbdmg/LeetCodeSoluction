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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int len = postorder.Length-1;
        return BuildingTree( inorder, postorder,  ref len , 0, len+1);
    }
    
    private TreeNode BuildingTree( int[] inorder, int[] postorder, ref int postIndex, int head, int tail ){
        if( postIndex<0 )
            return null;
        int goalInInorder = Array.IndexOf( inorder, postorder[postIndex] );
        
        TreeNode newNode = null;// = new TreeNode( postorder[postIndex] );
        
        if( goalInInorder<=tail && goalInInorder>=head )
            newNode =  new TreeNode( postorder[postIndex] );
        else
            return null;
        
        postIndex--;
        
        newNode.right = BuildingTree( inorder, postorder, ref postIndex, goalInInorder, tail);
        newNode.left = BuildingTree( inorder, postorder, ref postIndex, head, goalInInorder-1);
        
        return newNode;
    }
}