public class Solution {
    public void SortColors(int[] nums) {
        int[] freq = new[] {0, 0, 0};
            foreach (var va in nums)
                freq[va]++;

            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (freq[j] > 0){
                     nums[i] = j;
                    freq[j]--;
                } 
                else
                {
                    j++;
                    i--;
                }
            }
    }
}