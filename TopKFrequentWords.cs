public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var s in words) {
            if (!dict.ContainsKey(s))
                dict.Add(s, 0);
            dict[s]++;
        }
        PriorityQueue<string, (int, string)> pq = new PriorityQueue<string, (int, string)>();
        pq.EnqueueRange(dict.Select(p => (p.Key, (-p.Value, p.Key))));
        
        List<string> ret = new List<string>();
        while (k-- > 0) ret.Add(pq.Dequeue());
        
        return ret;
    }
}
