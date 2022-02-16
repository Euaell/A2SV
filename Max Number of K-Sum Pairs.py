class Solution:
    def maxOperations(self, nums: List[int], k: int) -> int:
        nums.sort()
        nums = list(filter(lambda x: x<k,nums))
        list2 = list(map(lambda x : k-x, nums))
        # list2.sort()
        frequency =0
        
        i=0
        j=0
        while i < len(nums) and not len(list2)==0:
            if(nums[i]==list2[len(list2)-1]):
                list2.pop()
                frequency = frequency+1
                i = i+1
                continue
            elif nums[i] > list2[len(list2)-1]:
                list2.pop()
                continue
            else :
                i = i+1
                continue
               
        return frequency // 2
