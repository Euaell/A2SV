class Solution:
    def largestNumber(self, nums: List[int]) -> str:
        x=[0]*len(nums)
        a=""
        for i in range(0,len(nums)):
            x[i]=str(nums[i])
        for i in range(0,len(nums)):
            if len(x[i])<10:
                length = 10-len(x[i])
      
                arr = x[i]*length
                x[i]=x[i]+arr
                x[i]= x[i][0:10]
          
        for i in range(0,len(nums)):
            x[i]=int(x[i])
            

        for i in range(0,len(nums)):
            for i in range(0,len(nums)-1):
                if  x[i]<x[i+1]:
                    x[i],x[i+1]=x[i+1],x[i]
                    nums[i],nums[i+1]=nums[i+1],nums[i]
                elif x[i]==x[i+1]:
                    if int(str(nums[i])+str(nums[i+1]))<int(str(nums[i+1])+str(nums[i])):
                        nums[i],nums[i+1]=nums[i+1],nums[i]       
                  
        for i in range(0,len(nums)) : 
            a = a + str(nums[i])
        return str(int(a))
