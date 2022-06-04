public class MyLinkedList {

    private LinkedList<int> list;
    public MyLinkedList()
    {
        list = new LinkedList<int>();
    }
    
    public int Get(int index) {
        if (index < list.Count)
            return list.ElementAt(index);
        return -1;
    }
    
    public void AddAtHead(int val)
    {
        list.AddFirst(val);
    }
    
    public void AddAtTail(int val) {
        list.AddLast(val);
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < list.Count)
        {
            LinkedListNode<int> x = list.First;
            while (index > 0)
            {
                x = x.Next;
                index--;
            }
            list.AddBefore(x, val);
        }
        else if (index == list.Count)
            list.AddLast(val);
    }
    
    public void DeleteAtIndex(int index) {
        if (index >= list.Count)
            return;
        LinkedListNode<int> x = list.First;
        while (index > 0)
        {
            x = x.Next;
            index--;
        }
        list.Remove(x);
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
