public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.EnqueueRange(nums.Select(x => (x, -x)));
        
        while (--k > 0) pq.Dequeue();
        
        return pq.Dequeue();
    }
}
