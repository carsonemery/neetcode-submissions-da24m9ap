// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//     pub val: i32,
//     pub left: Option<Rc<RefCell<TreeNode>>>,
//     pub right: Option<Rc<RefCell<TreeNode>>>,
// }
impl Solution {
    pub fn has_path_sum(root: Option<Rc<RefCell<TreeNode>>>, target_sum: i32) -> bool {
        fn dfs(node: &Option<Rc<RefCell<TreeNode>>>, cur_sum: i32, target: i32) -> bool {
            if let Some(n) = node {
                let n = n.borrow();
                let new_sum = cur_sum + n.val;
                if n.left.is_none() && n.right.is_none() {
                    return new_sum == target;
                }
                dfs(&n.left, new_sum, target) || dfs(&n.right, new_sum, target)
            } else {
                false
            }
        }
        dfs(&root, 0, target_sum)
    }
}
