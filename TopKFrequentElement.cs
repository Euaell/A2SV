public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (var va in nums)
        {
            if (freq.ContainsKey(va)) freq[va]++;
            else freq.Add(va, 1);
        }

        freq = freq.OrderBy(pair => pair.Value).Reverse().ToDictionary(pair => pair.Key, pair => pair.Value);
        return freq.Keys.ToArray()[..k];
        
    }
}
