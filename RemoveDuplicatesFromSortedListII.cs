public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        ListNode tmp = head;
        while (tmp != null) {
            int x = tmp.val;
            if (!dict.ContainsKey(x))
                dict.Add(x, 0);
            dict[x]++;
            tmp = tmp.next;
        }
        
        ListNode ret = new ListNode();
        tmp = ret;
        foreach (var node in dict) {
            if (node.Value == 1) {
                tmp.next = new ListNode(node.Key);
                tmp = tmp.next;
            }
        }
        
        return ret.next;
    }
}
