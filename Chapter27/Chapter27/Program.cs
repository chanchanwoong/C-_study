using System;

class C
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>();
        map.Add("a", 1);
        map.Add("b", 2);

        foreach (var key in map.Keys)
        {
            Console.WriteLine("" + key + " " + map[key]);
        }

        map["a"] = 3;
        map["b"] = 4;
        foreach (var key in map.Keys)
        {
            Console.WriteLine("" + key + " " + map[key]);
        }
    }
}