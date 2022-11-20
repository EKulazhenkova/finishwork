int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
int Akkerman(int n, int m)
{
if (n == 0)
{
return m + 1;
}
else if (n > 0 && m == 0)
{
return Akkerman(n - 1, 1);
}
else
{
return Akkerman(n - 1, Akkerman(n, m - 1));
}
}

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int akkermanFunction = Akkerman(n, m);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
    