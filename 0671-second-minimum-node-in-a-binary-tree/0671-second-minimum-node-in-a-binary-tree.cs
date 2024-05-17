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
    private int GetSecondMinimumValue(TreeNode root,int minMumValue){
        if(root==null)
            return -1;
        
        var value1 = GetSecondMinimumValue(root.left,minMumValue);
        var value2 = GetSecondMinimumValue(root.right,minMumValue);
        if(root.val>minMumValue)
            return root.val;
        else if(value1==-1)
            return value2;
        else if(value2==-1)
            return value1;
        return Math.Min(value1,value2);
    }
    public int FindSecondMinimumValue(TreeNode root) {
         if(root.left==null)
            return -1;
        return GetSecondMinimumValue(root,root.val);
    }
}