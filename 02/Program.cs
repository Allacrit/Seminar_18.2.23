Console.WriteLine("2. Показать натуральные числа от N до 1, N задано.");
Console.WriteLine(NumbersRangeN(10));

string NumbersRangeN(int N)
{
    return N < 1 ? String.Empty : $"{N} " + NumbersRangeN(N - 1);
}