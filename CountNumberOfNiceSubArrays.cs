public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int n = nums.Length;
        int[] oddCount = new int[n + 1];
        for (int i = 0; i < n; i++) {
            int t = 0;
            if (nums[i] % 2 == 1)
                t = 1;
            oddCount[i + 1] = oddCount[i] + t;
        }
        
        int ret = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict[0] = 1;
        for (int i = 1; i <= n; i++) {
            if (dict.ContainsKey(oddCount[i] - k))
                ret += dict[oddCount[i] - k];
            dict[oddCount[i]] = dict.ContainsKey(oddCount[i]) ? dict[oddCount[i]] + 1 : 1;
        }
        
        return ret;
    }
}
