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
    int result=0;
    private (int sum,int total) getAverage(TreeNode root){
         if(root==null)
            return (0,0);
        
        var totalSumLeft=getAverage(root.left);
        var totalSumRight=getAverage(root.right);
        var sum=totalSumLeft.sum+totalSumRight.sum+root.val;
        var total=totalSumLeft.total+totalSumRight.total+1;
        var average=sum/total;
        if(average==root.val)
            result++;
        return (sum,total);
    }
    public int AverageOfSubtree(TreeNode root) {
        getAverage(root);
        return result;
    }
}