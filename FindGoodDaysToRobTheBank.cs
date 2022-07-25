public class Solution {
    public IList<int> GoodDaysToRobBank(int[] security, int time) {
        int n = security.Length;
        
        // increasing
        int[] inc = new int[n];
        for (int i = 0; i < n - 1; i++) {
            if (security[i] < security[i + 1])
                inc[i + 1] = inc[i] + 1;
            else inc[i + 1] = inc[i];
        }
        // decreasing
        int[] dec = new int[n];
        for (int i = 0; i < n - 1; i++) {
            if (security[i] > security[i + 1])
                dec[i + 1] = dec[i] + 1;
            else dec[i + 1] = dec[i];
        }
        
        List<int> ret = new List<int>();
        for (int i = time; i < n - time; i++) {
            if (inc[i] - inc[i - time] <= 0 && dec[i+time] - dec[i ] <= 0)
                ret.Add(i);
        }        
        
        return ret;
    }
}
