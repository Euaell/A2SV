class Solution:
    def carFleet(self, target: int, position: List[int], speed: List[int]) -> int:
        dis = {}
        stack = []
        for i in range(len(position)):
            dis[position[i]] = (target-position[i])/speed[i]
        
        position.sort()
        
        for i in position:
            
            while len(stack) > 0 and stack[-1] <= dis[i]:
                stack.pop()
            
            stack.append(dis[i])
            
            
        return len(stack)
