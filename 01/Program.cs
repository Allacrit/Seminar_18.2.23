Console.WriteLine("1. Показать натуральные числа от 1 до N, N задано.");
Console.WriteLine(NumbersRange1NRec(10));

string NumbersRange1NRec(int N)
{
    return N < 1 ? String.Empty : NumbersRange1NRec(N - 1) + $"{N} ";
}