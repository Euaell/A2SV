public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(0, 1);
        
        int sum = 0;
        int ans = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (dict.ContainsKey(sum - k))
                ans += dict[sum - k];
            
            dict[sum] = dict.ContainsKey(sum) ? dict[sum] + 1 : 1;
        }
        
        return ans;
    }
}
