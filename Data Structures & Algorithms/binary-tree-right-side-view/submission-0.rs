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

impl Solution {
    pub fn right_side_view(root: Option<Rc<RefCell<TreeNode>>>) -> Vec<i32> {

        if root.is_none() {
            return Vec::new();
        }

        let mut right_nodes = Vec::new();
        let mut dequeue: VecDeque<Rc<RefCell<TreeNode>>> = VecDeque::new();        
        let mut level = 0;

        let root_rc = root.unwrap();
        dequeue.push_front(root_rc.clone());
        // right_nodes.push(root_rc.borrow().val);

        while !dequeue.is_empty() {

            let mut curr_length = dequeue.len();

            for i in 0..dequeue.len() {

                // if curr index is one away from the len of the deque, 
                // this is the rightmost node and we should add it to the right_node 
                // vector

                let node_rc = dequeue.pop_front().unwrap();
                let node = node_rc.borrow();

                if curr_length - i <= 1 {
                    right_nodes.push(node.val);
                }

                if let Some(left) = node.left.clone() {
                    dequeue.push_back(left);
                }
                if let Some(right) = node.right.clone() {
                    dequeue.push_back(right); 
                }            

            }
        }

        return right_nodes;

    }
}
