public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
                
        int[] ret = new int[n];
        ret[0] = 1;
        // preFix
        for (int i = 1; i < n; i++) {
            ret[i] = ret[i - 1] * nums[i - 1]; 
        }
        // suFfix
        int r = 1;
        for (int i = n - 1; i >= 0; i--) {
            ret[i] = r * ret[i];
            r *= nums[i];
        }
        
        return ret;
    }
}
