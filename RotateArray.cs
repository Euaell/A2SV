public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums == null)
            return;
        int[] ret = new int[nums.Length];
        Array.Copy(nums, ret, nums.Length);        
        int r = k % nums.Length;
        int startInd = nums.Length - r;
        int c = 0;
        for (int i = startInd; i < nums.Length; i++)
            nums[c++] = ret[i];
        for (int i = 0; i < startInd; i++)
            nums[c++] = ret[i];
    }
}
