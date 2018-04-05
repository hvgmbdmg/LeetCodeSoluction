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
    public IList<int> PreorderTraversal(TreeNode root) {
        //show, visit left, visit right;
        Stack<TreeNode> preStack = new Stack<TreeNode>();
        IList<int> result = new List<int>();
        
        preStack.Push(root);
        while( preStack.Count!=0 ){
            TreeNode tempNode = preStack.Pop();
            if( tempNode==null )
                continue;
            result.Add( tempNode.val );
            preStack.Push(tempNode.right);
            preStack.Push(tempNode.left);
        }
        
        return result;
    }
    
}