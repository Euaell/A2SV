class Solution:
    def checkArithmeticSubarrays(self, nums: List[int], l: List[int], r: List[int]) -> List[bool]:
        x = len(nums)
        answer=[]
        dis=[0]*(x-1)
       
        for  i in range(0, len(l)):
            bo = True
           
            check = nums[l[i]:r[i]+1]
            check.sort()
            dis =[0]*(len(check)-1)
            for j in range(0,len(check)-1):
                dis[j]=check[j+1]-check[j]
            for j in range(0,len(check)-2):
                if(dis[j]==dis[j+1]):
                    continue
                else :
                    bo = False
                   
                    break
            answer.append(bo)
        return answer
