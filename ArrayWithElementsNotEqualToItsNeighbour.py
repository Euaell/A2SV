class Solution:
    def rearrangeArray(self, nums: List[int]) -> List[int]:
        x = len(nums)
        nums.sort()
        for i in range(1,x-1,2):
            
            nums[i],nums[i+1]=nums[i+1],nums[i]
        return nums
