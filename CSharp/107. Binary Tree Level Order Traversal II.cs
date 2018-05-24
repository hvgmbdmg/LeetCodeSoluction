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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        addLevel( result, root, -1 );
        
        result.Reverse();
        
        return result;
    }
    
    void addLevel( IList<IList<int>> result, TreeNode root, int depth ){
        if( root==null )
            return;
        
        depth++;
        if( result.Count <= depth )
            result.Add( new List<int>() );  
        result[depth].Add( root.val );
        
        addLevel( result, root.left, depth );
        addLevel( result, root.right, depth );
    }
    
}