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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        //nums.Max( );
        return Recu( nums, 0, nums.Length );
    }
    private TreeNode Recu( int[] nums, int head, int tail ){
        int max = -Int32.MaxValue;
        int index = -1;
        if( head >= tail )
            return null;
        
        for( int i=head; i<tail; i++ ){
            if( max < nums[i] ){
                max = nums[i];
                index = i;
            }
        }
        
        TreeNode newNode = new TreeNode( max );
        newNode.left = Recu( nums, head, index );
        newNode.right = Recu( nums, index+1, tail );
        
        return newNode;
    }
}