public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int zeros = 0;
        
        int ret = 0;
        int left = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) zeros++;
            
            while (zeros > k) {
                if (nums[left] == 0)
                    zeros--;
                left++;
            }
            ret = Math.Max(ret, i - left + 1);
        }
        
        return ret;
    }
}
