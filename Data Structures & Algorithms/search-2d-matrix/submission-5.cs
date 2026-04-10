public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int columnCount = matrix[0].Length;

        // Use a for loop to check each row
        for (int i = 0; i < matrix.Length; i++) {
            if (target >= matrix[i][0] && target <= matrix[i][columnCount - 1]) {
                // Binary search row i
                // Return result

                int left = 0;
                int right = columnCount - 1;

                while (left <= right) {
                    int mid = (right + left) / 2;

                    if (target > matrix[i][mid]) {
                        left = mid + 1;
                    }
                    else if (target < matrix[i][mid]) {
                        right = mid - 1;
                    }
                    else {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
