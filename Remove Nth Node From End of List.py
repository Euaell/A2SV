class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        sz =0
        header = head
        while(header):
            sz+=1
            header=header.next
        if(sz==1):
            return None
        if(sz==n):
            head = head.next
            return head
        header=head
        sz-=n+1
        while(not sz== 0):
            header=header.next
            sz-=1
        header.next=header.next.next 
        return head
