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
    public bool helper(TreeNode root, int min, int max){
        if(root == null) return true;
        if(root.val < min || root.val > max) return false;
        return helper(root.left, min, root.val) && helper(root.right, root.val, max);
    }
    
    public bool IsValidBST(TreeNode root) {
        return helper(root, Int32.MinValue, Int32.MaxValue);
    }
}