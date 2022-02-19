class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        if (min(nums)>=0):
            y = [0]*(max(nums)+1)
            z=[0]*1
        elif min(nums)<0 and max(nums)>=0 :
            y = [0]*(max(nums)+1)
            z=[0]*(-1*min(nums)+1)
        elif min(nums)<0:
            z=[0]*(-1*min(nums)+1)
            y=[0]*1
        answer =[]
        for var in range(0,len(nums)):
            if(nums[var]>=0):
                y[nums[var]] = y[nums[var]]+1
            else:
                z[-1*nums[var]]=z[-1*nums[var]]+1
        for i in range(0,k):
            a = y.index(max(y))
            # a=0
            b = z.index(max(z))
            if max(y) > max(z):
                answer.append(a)
                y[a]=0
            else :
                answer.append(-1*b)
                z[b]=0
        return answer
