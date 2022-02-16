class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        header = head
        arr=[]
        i=0
        while(header):
            arr.append(header)
            header = header.next
            i=i+1
        return arr[(i)//2]  
