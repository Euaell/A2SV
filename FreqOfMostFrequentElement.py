class Solution:
    def maxFrequency(self, nums: List[int], k: int) -> int:
        l = 0
        n = len(nums)
        ans = 0
        windowSum = 0
        
        nums.sort()
        
        for r in range(n):
            windowSum  += nums[r]
            
            totalSum = (r-l+1) * nums[r]
            
            while (totalSum - windowSum) > k:
                windowSum -= nums[l]
                l+=1
                totalSum = (r-l+1) * nums[r]
            ans = max(ans,r-l+1)
        
        return ans
