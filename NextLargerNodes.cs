public class Solution {
    public int[] NextLargerNodes(ListNode head) {
        List<int> ret = new List<int>();
        while (head != null)
        {
            int x = 0;
            var temp = head.next;
            while (temp != null)
            {
                int y = temp.val;
                if (y > x && y > head.val)
                {
                    x = y;
                    break;
                }
                temp = temp.next;
            }
            
            ret.Add(x);
            head = head.next;
        }
        return ret.ToArray();
    }
}
