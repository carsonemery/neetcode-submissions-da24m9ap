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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        
        return recurse(root, result);

        
    }

    public List<int> recurse(TreeNode root, List<int> result) {
        if (root == null) {
            return result;
        }

        recurse(root.left, result);
        result.Add(root.val);
        recurse(root.right, result);

        return result;
    }
}