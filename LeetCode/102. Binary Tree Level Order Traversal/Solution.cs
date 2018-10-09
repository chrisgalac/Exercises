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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> levels = new List<IList<int>>();
        
        IList<TreeNode> curr = new List<TreeNode>();
        curr.Add(root);
        
        while(curr.Count != 0){
            IList<int> level = new List<int>();
            IList<TreeNode> children = new List<TreeNode>();
            
            for(int i = 0; i < curr.Count; i++){
                level.Add(curr[i].val);
                if(curr[i].left != null) children.Add(curr[i].left);
                if(curr[i].right != null) children.Add(curr[i].right);
            }
            
            levels.Add(level);
            curr = children;
        }
        
        return levels;
    }
}