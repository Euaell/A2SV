/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) // works
    {
        var ret = new ListNode();
        var last = ret;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                last.next = list1;
                list1 = list1.next;
            }
            else
            {
                last.next = list2;
                list2 = list2.next;
            }
            last = last.next;
        }

        if (list1 != null)
            last.next = list1;
        if (list2 != null)
            last.next = list2;
        return ret.next;
    }
    
    public ListNode SortList(ListNode head) {
        if (head?.next == null)
            return head;
        ListNode fast = head;
        ListNode slow = head;
        ListNode hold = head;
        while (fast.next?.next != null)
        {
            hold = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        if (fast.next != null && fast.next.next == null)
        {
            hold = slow;
            slow = slow.next;
        }

        hold.next = null; // separate the two lists
        return MergeTwoLists(SortList(head), SortList(slow));
    }
}
