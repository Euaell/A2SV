public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = nums.Sum();
        int left = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (left == (sum - (left + nums[i])))
                return i;
            left += nums[i];
        }
        
        return -1;
    }
}
