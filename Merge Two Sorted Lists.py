class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if (list1 == None and list2==None):
            return list1
        head = ListNode(0,None)
        header = head
        while(  list1  and list2 ):
            if(list1.val <= list2.val):
                header.val = list1.val
                list1 = list1.next
            else:
                header.val = list2.val
                list2 = list2.next    
            header.next = ListNode(0,None)
            header = header.next    
        if(list1):
            header.val =list1.val
            header.next = list1.next
        elif(list2):
            header.val = list2.val
            header.next = list2.next
        return head
