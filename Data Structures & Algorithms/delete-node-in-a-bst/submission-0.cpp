/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    TreeNode* deleteNode(TreeNode* root, int key) {
        if (root == nullptr) {
            return root;
        }

        if (root->val > key) {
            // traverse to left 
            root->left = deleteNode(root->left, key);
        }
        else if (root->val < key) {
            // traverse to right
            root->right = deleteNode(root->right, key);
        }
        else {
            // we are on the node that needs to be deleted now
            if (root->left == nullptr) {
                return root->right;
            }
            else if (root->right == nullptr) {
                return root->left;
            } else {
                TreeNode *minNode = findMinValueNode(root->right);
                root->val = minNode->val;
                root->right = deleteNode(root->right, minNode->val);
            }
        }

        return root;
    }

    TreeNode* findMinValueNode(TreeNode *root) {
        TreeNode *curr = root;
        while (curr != nullptr && curr->left != nullptr) {
            curr = curr->left;
        }
        return curr;
    }



};