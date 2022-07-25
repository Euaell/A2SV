public class Solution {
    public int MinSetSize(int[] arr) {
        int n = arr.Length;
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (var v in arr) {
            if (!freq.ContainsKey(v))
                freq.Add(v, 0);
            freq[v]++;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.EnqueueRange(freq.Select(x => (x.Value, -x.Value)));
        
        int ans = 0;
        while (n > arr.Length / 2) {
            var tmp = pq.Dequeue();
            n -= tmp;
            ans += 1;
        }
        return ans;
    }
}
