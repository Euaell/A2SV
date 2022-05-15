public class Solution
{
    private double dist(int x, int y)
    {
        return Math.Sqrt(x * x + y * y);
    }
    public int[][] KClosest(int[][] points, int k) // works
    {
        Dictionary<int[], double> u = new Dictionary<int[], double>();
        foreach (var va in points)
        {
            var (f, s) = (va[0], va[1]);
            if (!u.ContainsKey(new []{f, s})) u.Add(new []{f, s}, dist(f, s));
        }

        return u.OrderBy(pair => pair.Value).Take(k).ToDictionary(pair => pair.Key, pair => pair.Value).Keys.ToArray();
    }
}
