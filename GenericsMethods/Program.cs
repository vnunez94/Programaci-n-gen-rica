int x = 10, y = 20;
string s1 = "Manza", s2 = "Pera";

Console.WriteLine($"x={x}, y={y}");
Console.WriteLine($"s1={s1}, s2={s2}");

Utility.Swap<int>(ref x, ref y);
Utility.Swap<string>(ref s1, ref s2);
Console.WriteLine();
Console.WriteLine($"x={x}, y={y}");
Console.WriteLine($"s1={s1}, s2={s2}");



public static class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T tmp=a; 
        a=b; 
        b=tmp;
    }
}