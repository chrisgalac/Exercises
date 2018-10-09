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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> levels = new List<IList<int>>();
        
        IList<TreeNode> curr = new List<TreeNode>();
        curr.Add(root);
        
        bool lToR = true;
        while(curr.Count != 0){
            IList<int> level = new List<int>();
            
            if(lToR){
                for(int i = 0; i < curr.Count; i++){
                    level.Add(curr[i].val);
                }
            }
            else{
                for(int i = curr.Count - 1; i >= 0; i--){
                    level.Add(curr[i].val);
                }
            }
            levels.Add(level);
            
            IList<TreeNode> children = new List<TreeNode>();
            for(int i = 0; i < curr.Count; i++){
                if(curr[i].left != null) children.Add(curr[i].left);
                if(curr[i].right != null) children.Add(curr[i].right);
            }
            
            lToR = !lToR;
            curr = children;
        }
        
        return levels;
    }
}