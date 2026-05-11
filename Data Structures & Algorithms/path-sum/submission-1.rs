impl Solution {
    pub fn has_path_sum(root: Option<Rc<RefCell<TreeNode>>>, target_sum: i32) -> bool {
        let root = match root {
            Some(r) => r,
            None => return false,
        };

        let root_val = root.borrow().val;
        
        let mut queue: VecDeque<(Rc<RefCell<TreeNode>>, i32)> =
            VecDeque::from([(root, target_sum - root_val)]);

        while let Some((node, curr_sum)) = queue.pop_front() {
            let node = node.borrow();
            if node.left.is_none() && node.right.is_none() && curr_sum == 0 {
                return true;
            }
            if let Some(ref left) = node.left {
                let lv = left.borrow().val;
                queue.push_back((Rc::clone(left), curr_sum - lv));
            }
            if let Some(ref right) = node.right {
                let rv = right.borrow().val;
                queue.push_back((Rc::clone(right), curr_sum - rv));
            }
        }

        false
    }
}
