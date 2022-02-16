class Solution:
    def nextGreaterElement(self, nums1: List[int], nums2: List[int]) -> List[int]:
        stack = []
        answer=[]
        dis = {}
        for i in range(0,len(nums2)):
            
            
            while len(stack) > 0 and nums2[i] > stack[-1]:
                
                dis[stack[-1]] = nums2[i]
                stack.pop()
             
            stack.append(nums2[i])
            
          
        for i in range(len(stack)):
            dis[stack[i]] = -1
        
        for i in range(0,len(nums1)):
            answer.append(dis[nums1[i]])
            
            
        return answer
