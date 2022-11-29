//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число: ");
string A1=Console.ReadLine()!;
Console.WriteLine("Введите второе число: ");
string B1=Console.ReadLine()!;
Console.WriteLine("Введите третье число: ");
string C1=Console.ReadLine()!;
int A=int.Parse(A1);
int B=int.Parse(B1);
int C=int.Parse(C1);
if (A>B && A>C)
{
    string max=A.ToString();
    Console.WriteLine("Максимальное число: " + A);
}
else if (A<B && B>C)
{
    string max=B.ToString();
    Console.WriteLine("Максимальное число: " + B);
}
else if (A<C && B<C)
{
    string max=C.ToString();
    Console.WriteLine("Максимальное число: " + C);
}
else
{
    Console.WriteLine("Максимальных чисел несколько!");
}