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
    public int PairSum(ListNode head) {
        Stack<int> x = new Stack<int>();
        ListNode fast = head;
        ListNode slow = head;
        while (fast.next?.next != null)
        {
            x.Push(slow.val);
            slow = slow.next;
            fast = fast.next.next;
        }
        x.Push(slow.val);
        // for even length choose the next node as a middle
        if (fast.next != null && fast.next.next == null)
            slow = slow.next;

        // slow is equal to the middle of the list
        int mts = 0;
        while (slow != null)
        {
            int temp = x.Pop() + slow.val;
            mts = temp > mts ? temp : mts;
            slow = slow.next;
        }

        return mts;
    }
}
