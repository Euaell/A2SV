class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        intervals.sort()
        i=0
        j=0
        while (i< len(intervals)-1) :
            if(intervals[i][0]==intervals[i+1][0]):
                intervals.pop(i)
                i=i-1
            i=i+1
        while j<len(intervals)-1:
            if(intervals[j][1]>=intervals[j+1][1]):
                intervals.pop(j+1)
                continue
            if(intervals[j][1]>=intervals[j+1][0]):
                intervals[j][1]=intervals[j+1][1]
                intervals.pop(j+1)
                j=j-1
            j=j+1
        return intervals
