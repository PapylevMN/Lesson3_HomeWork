// Программа определения числового полиндрома

Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine());
bool flag = true;
string s = Convert.ToString(Math.Abs(n));
for (int i = 0; i < s.Length/2+1; i++)
{
    if (s[i] != s[s.Length - 1 - i])
    {
        flag = false;
        break;
    }
}
Console.WriteLine(flag ? "да": "нет");

