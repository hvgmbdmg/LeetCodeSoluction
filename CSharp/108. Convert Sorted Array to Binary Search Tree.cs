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
    public TreeNode SortedArrayToBST(int[] nums) {
        return CreatBST( nums, nums.Length/2, 0, nums.Length-1);
    }
    
    private TreeNode CreatBST( int[] nums, int rootIndex, int start, int end ){
        if( end < start )
            return null;
        TreeNode newNode = new TreeNode( nums[rootIndex] );
        
        newNode.left = CreatBST( nums, (start+rootIndex-1)/2, start, rootIndex-1);
        newNode.right = CreatBST( nums, (rootIndex+1+end)/2, rootIndex+1, end);
        
        return newNode;
    }
}