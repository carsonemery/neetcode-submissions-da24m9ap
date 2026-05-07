// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//     pub val: i32,
//     pub left: Option<Rc<RefCell<TreeNode>>>,
//     pub right: Option<Rc<RefCell<TreeNode>>>,
// }
//
// impl TreeNode {
//     #[inline]
//     pub fn new(val: i32) -> Self {
//         TreeNode {
//             val,
//             left: None,
//             right: None,
//         }
//     }
// }

use std::rc::Rc;
use std::cell::RefCell;
use std::collections::VecDeque;

impl Solution {
    pub fn level_order(root: Option<Rc<RefCell<TreeNode>>>) -> Vec<Vec<i32>> {

        if root.is_none() {
            return Vec::new();
        }

        let mut queue: VecDeque<Rc<RefCell<TreeNode>>> = VecDeque::new();
        let mut list: Vec<Vec<i32>> = Vec::new();
        queue.push_front(root.unwrap());

        let mut index = 0;
        while !queue.is_empty() {
            list.push(Vec::new());
            for _ in 0..queue.len() {
                let node_rc = queue.pop_front().unwrap();
                let node = node_rc.borrow();
                
                if let Some(left) = node.left.clone() {
                    queue.push_back(left);
                }
                if let Some(right) = node.right.clone() {
                    queue.push_back(right);
                }

                list[index].push(node.val);  // <- you were also missing this line
            }                                // closes for
            index += 1;                      // <- and this
        }                                    // closes while

        return list;
    }                                        // closes fn
}                                            // closes impl