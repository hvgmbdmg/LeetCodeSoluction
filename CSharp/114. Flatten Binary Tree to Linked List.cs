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
    public void Flatten(TreeNode root) {
        //show, visit left, visit right;
        Stack<TreeNode> stackNode = new Stack<TreeNode>();
        TreeNode result = new TreeNode(0);// = root;
        TreeNode now;
        
        stackNode.Push( root );
        while( stackNode.Count!=0 ){
            now = stackNode.Pop();
            if( now==null )
                continue;
            
            stackNode.Push( now.right );
            stackNode.Push( now.left );
            
            result.right = now;
            result.left = null;
            result = result.right;
        }
    }
}