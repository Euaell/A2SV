public class Solution {
    public int TotalFruit(int[] fruits) {
        Dictionary<int, int> freq = new Dictionary<int, int>();  
        
        int left = 0;
        int ret = 0;
        
        for (int i = 0; i < fruits.Length; i++) {
            
            if (!freq.ContainsKey(fruits[i]))
                freq.Add(fruits[i], 0);
            freq[fruits[i]]++;
            
            while (freq.Count > 2) {
                freq[fruits[left]]--;
                if (freq[fruits[left]] == 0)
                    freq.Remove(fruits[left]);
                left++;
            }
            
            ret = Math.Max(ret, i - left + 1);
        }
        
        return ret;
    }
}
