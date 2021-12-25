public class Solution {
    public string SortSentence(string s) {
       List<string> temp = s.Split(' ').ToList();
            SortedDictionary<int, string> temp2 = new SortedDictionary<int, string>();
            foreach (var va in temp)
            {
                int x;
                Int32.TryParse(va.Last().ToString(), out x);
                temp2.Add(x, va.Remove(va.Length - 1));
            }
            var y = temp2.Values.ToList();
            
            return String.Join(" ", y); 
    }
}