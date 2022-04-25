public class Solution {
    int Rec(int [] nums, int sINd, int eInd)
    {
        return sINd == eInd ? nums[sINd] : Math.Max(nums[sINd] - Rec(nums, sINd + 1, eInd), nums[eInd] - Rec(nums, sINd, eInd - 1));
    }
    public bool PredictTheWinner(int[] nums)
    {
        return Rec(nums, 0, nums.Length - 1) >= 0;
    }
}
