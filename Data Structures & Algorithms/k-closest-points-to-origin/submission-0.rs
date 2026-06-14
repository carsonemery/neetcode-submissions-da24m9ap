use std::collections::BinaryHeap;
use std::cmp::Ordering;

#[derive(Eq, PartialEq)]
struct Point {
    euc_distance: i32,
    x: i32,
    y: i32,
}

impl Ord for Point {
    fn cmp(&self, other: &Self) -> Ordering {
        self.euc_distance.cmp(&other.euc_distance)
    }
}

impl PartialOrd for Point {
    fn partial_cmp(&self, other: &Self) -> Option<Ordering> {
        Some(self.cmp(other))
    }
}

impl Solution {

    pub fn k_closest(points: Vec<Vec<i32>>, k: i32) -> Vec<Vec<i32>> {
    
        let mut max_heap = BinaryHeap::new();

        for point in points.iter() {
            let mut distance: i32 = Self::square(point[0] - 0) + Self::square(point[1] - 0);

            max_heap.push(Point {euc_distance: distance,
                                x: point[0],
                                y: point[1]
                                });

            // If the size of the heap exceeds k, we remove the farthest
            // point, which can be done quickly simply by popping from the heap
            if max_heap.len() > k.try_into().unwrap() {
                max_heap.pop();
            }     
        }

        return Self::extract_2d_vec(max_heap);

    }

    fn extract_2d_vec(max_heap: BinaryHeap<Point>) -> Vec<Vec<i32>> {
        return max_heap.into_vec().into_iter().map(|item| vec![item.x, item.y]).collect();
    }

    fn square(val: i32) -> i32 {
        return val * val;
    }

}
