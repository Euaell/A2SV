class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        header=head
        while(head and header.next):
            if (header.val == header.next.val):
                header.next=header.next.next
            else:
                header=header.next
        return head         
