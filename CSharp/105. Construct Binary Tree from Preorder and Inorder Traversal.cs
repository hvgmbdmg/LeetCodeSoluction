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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int len = 0;
        return BuildingTree( preorder, inorder, ref len, 0, inorder.Length  );
    }
    private TreeNode BuildingTree( int[] preorder, int[] inorder, ref int preIndex, int start, int end ){
        if( start >= end )
            return null;

        int goalInInorder = Array.IndexOf( inorder, preorder[preIndex] );
        TreeNode newNode;
        if( goalInInorder>= start && goalInInorder<end )
            newNode = new TreeNode(preorder[preIndex]);
        else
            return null;
        
        preIndex++;
        newNode.left = BuildingTree( preorder, inorder, ref preIndex, start, goalInInorder );
        newNode.right = BuildingTree( preorder, inorder, ref preIndex, goalInInorder+1, end );
        
        return newNode;
        
    }
}