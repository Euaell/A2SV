class Solution:
    def minPairSum(self, nums: List[int]) -> int:
        nums.sort()
        x = len(nums)//2
        m=[0]*(x)
        for i in range(0,len(nums)):
            if i < x :
                
                m[i]=nums[i]+nums[len(nums)-1-i]
            else :
                break
        return max(m)
