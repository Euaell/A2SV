public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        int max = nums.Max();
            List<int> freq = new List<int>();
            for (int i = 0; i < max + 1; i++)
                freq.Add(0);
            foreach (var t in nums)
                freq[t] += 1;
            var ret = new List<int>();// returns the sorted array
            for (int i = 0; i < freq.Count; i++)
                for (int j = 0; j < freq[i]; j++)
                        ret.Add(i);
            
            var ret1 = new List<int>();
            for (int i = 0; i < ret.Count; i++)
                if (ret[i] == target)
                    ret1.Add(i);
            
            return ret1;
    }
}