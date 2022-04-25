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
    public ListNode ReverseList(ListNode head) // works
    {
        ListNode prev = null;

        while (head != null)
        {
            var temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        return prev;
    }
    public ListNode MiddleNode(ListNode head) // works
    {
        ListNode fast = head;
        ListNode slow = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        if (fast.next != null && fast.next.next == null)
            slow = slow.next;

        return slow;
    }
    public void ReorderList(ListNode head) {
        ListNode first = head;
        ListNode mid = ReverseList(MiddleNode(head));

        while (first != null && mid != null)
        {
            ListNode temp = first.next;
            first.next = mid;
            first = temp;

            temp = mid.next;
            mid.next = first;
            mid = temp;
        }
        if(first!= null)
            first.next=null ;
    }
}
