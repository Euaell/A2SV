public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        int n = pushed.Length;
        Stack<int> stk = new Stack<int>();
        
        int j = 0;
        foreach (var va in pushed) {
            stk.Push(va);
            while (stk.Count != 0 && j < n && stk.Peek() == popped[j]) {
                stk.Pop();
                j++;
            }
        }
        
        return j == n;
    }
}
