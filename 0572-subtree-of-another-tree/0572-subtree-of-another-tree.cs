/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private bool IsSubtreeCurrentNode(TreeNode root, TreeNode subRoot){
         if(subRoot is null&&root is null)
             return true;
         if(subRoot is null||root is null)
             return false;
         return root.val==subRoot.val
              &&IsSubtreeCurrentNode(root.left,subRoot.left)
              &&IsSubtreeCurrentNode(root.right,subRoot.right);

    }
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root is null)
             return false;
        return IsSubtreeCurrentNode(root,subRoot)||IsSubtree(root.left,subRoot)||IsSubtree(root.right,subRoot);
    }
}