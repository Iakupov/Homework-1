// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N: ");
string N1=Console.ReadLine()!;
int N=int.Parse(N1);
int i=1;
N1=N.ToString();
Console.WriteLine("Четные числа от 1 до " + N1+":");
while (i<=N)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
i++;
}
