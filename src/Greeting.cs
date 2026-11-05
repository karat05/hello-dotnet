namespace HelloDotnet;

public static class Greeting
{
    public static string Greet(string name) => $"Hello, {name}!";
    public static int SumRange(int from, int to) => Enumerable.Range(from, to - from + 1).Sum();
}
