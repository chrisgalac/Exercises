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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return buildTreeHelp(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
    }
    
    public TreeNode buildTreeHelp(int[] preorder, int[] inorder, int pl, int pr, int il, int ir){
        if(pl > pr || il > ir) return null;
        if(pl == pr) return new TreeNode(preorder[pl]);
        
        TreeNode root = new TreeNode(preorder[pl]);
        
        int im = il;
        
        while(im <= ir && inorder[im] != preorder[pl]) im++;
        root.left = buildTreeHelp(preorder, inorder, pl+1, pl+(im-il), il, im-1);
        root.right = buildTreeHelp(preorder, inorder, im+1, pr, im+1, ir);
        
        return root;
        
    }
}