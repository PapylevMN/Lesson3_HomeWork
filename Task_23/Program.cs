Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
Console.Write(n + " -> 1");
for (int i = 2; i < n+1; i++)
{
    Console.Write(", " + Math.Pow(i, 3));
}
