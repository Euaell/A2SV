class Solution {
public:
    int winner(vector<int>& nums, int sInd, int eInd){
        return sInd == eInd ?
                nums[sInd] :
                max(nums[sInd] - winner(nums, sInd + 1, eInd), nums[eInd] - winner(nums, sInd, eInd - 1));
    }
    bool PredictTheWinner(vector<int>& nums) {
        return winner(nums, 0, nums.size() - 1) >= 0;
    }
    
};
