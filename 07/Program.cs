Console.Clear();
Console.WriteLine("7. Написать программу возведения числа А в целую стень B.");

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()?? "");

Console.WriteLine($"Число {A} в степени {B} равно {degreeAB(A,B)}.");


int degreeAB(int a, int b)
{
    if(b==0) return 1;
    else return degreeAB(a, b - 1) * a;
}