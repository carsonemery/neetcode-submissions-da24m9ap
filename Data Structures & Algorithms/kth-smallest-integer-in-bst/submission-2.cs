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

public class Solution 
{
    public int KthSmallest(TreeNode root, int k) 
    {
        int result = -1;
        recurse(root, ref k, ref result);
        return result;
    }

    public void recurse(TreeNode node, ref int k, ref int result)
    {
        if (node == null || k <= 0)
        {
            return;
        }


        recurse(node.left, ref k, ref result);

        k--;
        if (k == 0)
        {
            result = node.val;
            return;
        }

        recurse(node.right, ref k, ref result);

    }
}
