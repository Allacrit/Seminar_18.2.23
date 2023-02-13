Console.WriteLine("3. Показать натуральные числа от M до N, N и M заданы.");
Console.WriteLine(NumbersRangeMN(10, 20));

string NumbersRangeMN(int M, int N)
{
    return M > N ? String.Empty : $"{M} " + NumbersRangeMN(M + 1, N);
}