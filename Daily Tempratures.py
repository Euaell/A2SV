class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        stack = []
        answer=[0]*(len(temperatures))
        for i in range(len(temperatures)):
            while len(stack) > 0  and  temperatures[i] > temperatures[stack[-1]] :
                answer[stack[-1]] = i - stack[-1]
                stack.pop()
             
            
            stack.append(i)    
                       
        for i in stack:
            answer[i] = 0
            
            
        return answer
