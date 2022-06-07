public class Solution {
    private ListNode MergeTwoLists(ListNode list1, ListNode list2)
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
    private ListNode merge(ListNode[] lists, int start, int end)
    {
        if (start == end) return lists[start];
        int mid = (start + end) / 2;
        var left = merge(lists, start, mid);
        var right = merge(lists, mid + 1, end);
        return MergeTwoLists(left, right);
    }
    public ListNode MergeKLists(ListNode[] lists)
    {
        return lists.Length == 0 ? null : merge(lists, 0, lists.Length - 1);
    }
}
