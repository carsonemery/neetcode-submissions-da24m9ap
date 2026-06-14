use std::collections::BinaryHeap;
use std::cmp::Ordering;

#[derive(PartialEq, Eq, PartialOrd, Ord)]
struct Point {
    euc_distance: i32,
    x: i32,
    y: i32,
}

impl Solution {

    pub fn k_closest(points: Vec<Vec<i32>>, k: i32) -> Vec<Vec<i32>> {
    
        let mut max_heap = BinaryHeap::new();

        for point in points.iter() {
            let mut squared_magnitude: i32 = point[0] * point[0] + point[1] * point[1];

            max_heap.push(Point {euc_distance: squared_magnitude,
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

}
