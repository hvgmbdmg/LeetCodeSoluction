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
    public IList<int> InorderTraversal(TreeNode root) {
        //visit left, show val, visit right;
        Stack<TraverNode> preStack = new Stack<TraverNode>();
        IList<int> result = new List<int>();
        
        preStack.Push( new TraverNode(1,root) );
        
        while( preStack.Count!=0 ){
            TraverNode tempNode = preStack.Pop();
            
            if( tempNode.node == null )
                continue;
            
            if( tempNode.doing == 0 )
                result.Add( tempNode.node.val );
            else{
                preStack.Push( new TraverNode(1,tempNode.node.right) );
                preStack.Push( new TraverNode(0,tempNode.node) );
                preStack.Push( new TraverNode(1,tempNode.node.left) );
            }
        }
        
        return result;
    }
    
    public class TraverNode {
        public TreeNode node;
        public int doing;//0 show, 1 visit;
        public TraverNode( int doing,TreeNode node ) {
            this.doing = doing;
            this.node = node;
        }
    }//TraverNode class;
}