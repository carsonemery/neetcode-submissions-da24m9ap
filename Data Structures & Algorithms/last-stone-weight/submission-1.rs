impl Solution {
    pub fn last_stone_weight(stones: Vec<i32>) -> i32 {

        let mut heap = BinaryHeap::from(stones);

        while heap.len() > 1 {
            let first = heap.pop().unwrap();
            let second = heap.pop().unwrap();

            // first should always be greater than second if we 
            // have a true maxHeap so we just need to negate the ==
            // conditional
            if first != second {
                heap.push(first - second);
            }


        }

        return heap.pop().unwrap_or(0);

    }
}
