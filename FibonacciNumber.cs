public class Solution {
    public int Fib(int n) {
        switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return Fib(n - 1) + Fib(n - 2);
            }
    }
}