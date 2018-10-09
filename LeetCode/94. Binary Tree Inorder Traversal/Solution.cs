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
        IList<int> inorder = new List<int>();
        
        Stack<TreeNode> toVisit = new Stack<TreeNode>();
        TreeNode curr = root;
        
        while(curr != null || toVisit.Count != 0){
            while(curr != null){
                toVisit.Push(curr);
                curr = curr.left;
            }
            
            curr = toVisit.Pop();
            inorder.Add(curr.val);
            curr = curr.right;
        }
        
        return inorder;
    }
}