

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, int> a = new Dictionary<int, int>();
        a.Add(1, 2);
        a.Add(2, 2);
        //a.Add(4, 5);
        a.Add(5, 1);

        a[1]++;

        int maxKey = a.Keys.First();
        foreach(KeyValuePair<int, int> pair in a)
        {
            if (pair.Value > a[maxKey]) maxKey = pair.Key;
            if (a.ContainsKey(pair.Key)) ;
        }

        int c = Math.Max(1, 2);

        Console.WriteLine(maxKey);
    }
}