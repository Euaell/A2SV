public class Solution {
    public ListNode SwapPairs(ListNode head) {
        
        if (head == null) return null;
        ListNode nxt = head.next;
        if (nxt == null) return head;

        (head.next, nxt.next) = (nxt.next, head);

        if (head.next != null)
            head.next = SwapPairs(head.next);

        return nxt;
    }
}
