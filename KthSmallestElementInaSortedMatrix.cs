public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (var v in matrix)
            pq.EnqueueRange(v.Select(x => (x, x)));
        
        while (--k > 0) pq.Dequeue();
        
        return pq.Dequeue();
    }
}
