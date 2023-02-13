Console.WriteLine("4. Найти сумму элементов от M до N, N и M заданы.");
Console.WriteLine(SumRangeMN(3, 7));

int SumRangeMN(int M, int N)
{
    return M > N ? 0 : M + SumRangeMN(M + 1, N);
}