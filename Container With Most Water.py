class Solution:
    def maxArea(self, height: List[int]) -> int:
        area=[]
        start = 0
        end = len(height)-1
        
        while(not start ==end):
            area.append(min(height[start],height[end])*(end-start))
            if(height[start]<=height[end]):
                start =start+1
            else:
                end =end-1
        return max(area) 
