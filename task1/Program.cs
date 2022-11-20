Console.Write("Введи M: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");
if (N>M)
for (int i = M; i <= N; i++)
    Console.Write($" {i}");
else
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");