Console.Clear();
Console.WriteLine("8. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем.");

Console.Write("Введите первое число : ");
int numА = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число : ");
int numB = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите нужное количество дополнительных чисел : ");
int numN = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"{numА} {numB} ");
FillArray(numА, numB, numN);

int FillArray(int numberA, int numberB, int amountNumber)
{
    int numberC = 0;
    if (amountNumber <= 1)
    {
        numberC = numberA + numberB;
    }
    if (amountNumber + 1 > 1)
    {
        numberC = numberA + numberB;
        numberA = numberB;
        numberB = numberC;
        amountNumber = amountNumber - 1;
        Console.Write($"{numberC} ");
        FillArray(numberA, numberB, amountNumber);
    }
    return numberC;
}