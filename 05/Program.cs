Console.Clear();
Console.Write("5. Найти сумму цифр числа: ");

int number = int.Parse(Console.ReadLine());

Console.WriteLine(SplitNumber(number));

int SplitNumber(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SplitNumber(number / 10);
}