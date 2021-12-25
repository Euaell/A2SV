public class Solution {
    public bool cusChecker(int[] arr, int start, int end)
        {
            List<int> temp = new List<int>();
            for (int i = start; i < end + 1; i++)
                temp.Add(arr[i]);
            temp.Sort();
            int dif = temp[1] - temp[0];
            for (int i = 2; i < temp.Count; i++)
                if (temp[i] - temp[i -1] != dif)
                    return false;
            return true;
        }
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
            List<bool> ret = new List<bool>();
            for (int i = 0; i < l.Length; i++)
            {
                bool x = cusChecker(nums, l[i], r[i]);
                ret.Add(x);
            }

            return ret;
        }
}