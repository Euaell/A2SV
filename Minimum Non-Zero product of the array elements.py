class Solution:
    def minNonZeroProduct(self, p: int) -> int:
        x=(pow(2,p)-1)
        return (x*pow(x-1,x//2,(10**9)+7))%(10**9+7)
