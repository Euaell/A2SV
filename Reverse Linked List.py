class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev=None
        curr = head
        if head==None:
            return head
        return self.rever(head,prev)
    def rever(self,header,prev):
        y = header.next
        header.next = prev
        prev = header
        if y == None:
            return header
       
        return self.rever(y,prev)
