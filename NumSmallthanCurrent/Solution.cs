public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
       int[] x = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                    if (nums[j] < nums[i] && i != j)
                        x[i]++;
            }

            return x; 
    }
}