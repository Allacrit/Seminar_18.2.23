Console.Clear();
Console.WriteLine("6. Написать программу вычисления функции Аккермана.");

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

if (numA >= 0 && numB >= 0)
{
    int result = AkkermanFunction(numA, numB);
    Console.WriteLine($"Результат вычисления функции Аккермана ввденными данными ({numA}, {numB}) является: {result}.");
}
else Console.WriteLine("Вычисления функции Аккермана не допустимо с отрицательными числами");

int AkkermanFunction(int i, int j)
{
    if (i == 0)
        return j + 1;
    else
      if ((i != 0) && (j == 0))
        return AkkermanFunction(i - 1, 1);
    else
        return AkkermanFunction(i - 1, AkkermanFunction(i, j - 1));
}