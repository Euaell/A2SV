public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        
        int left = 0;
        int ret = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (!freq.ContainsKey(s[i]))
                freq.Add(s[i], 0);
            freq[s[i]]++;
            
            while (freq[s[i]] > 1) {
                freq[s[left]]--;
                left++;
            }
            ret = Math.Max(i - left +1,ret);        
        }
        
        return ret;
    }
}
