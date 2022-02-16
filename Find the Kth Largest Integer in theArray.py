class Solution:
    def kthLargestNumber(self, nums: List[str], k: int) -> str:
        x = len(nums)
        y=[0]*x
        for i in range(0,x):
            y[i]=int(nums[i])
        y.sort()
        y.reverse()
        return str(y[k-1])
