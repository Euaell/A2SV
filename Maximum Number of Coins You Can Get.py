
import random
class Solution:
    def maxCoins(self, piles: List[int]) -> int:
        piles.sort()
        max=0
        i=0
        # for i in range(1,len(piles),3):
        #     max = max+ piles[i]
        while(len(piles)>0):
            max = max + piles[len(piles)-2]
            piles.pop(len(piles)-1)
            piles.pop(len(piles)-1)
            piles.pop(0)
            
        return max  
