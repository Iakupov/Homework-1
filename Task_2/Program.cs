// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
string A=Console.ReadLine()!;
Console.WriteLine("Введите второе число: ");
string B=Console.ReadLine()!;
int Pervoe_chislo=int.Parse(A);
int Vtoroe_chislo=int.Parse(B);
if (Pervoe_chislo>Vtoroe_chislo)
{
    A=Pervoe_chislo.ToString();
    Console.WriteLine("Наибольшое число: "+ A);
    B=Vtoroe_chislo.ToString();
    Console.WriteLine("Наименьшее число: "+ B);
}
else if (Pervoe_chislo<Vtoroe_chislo)
{
    A=Pervoe_chislo.ToString();
    Console.WriteLine("Наибольшое число: "+ B);
    B=Vtoroe_chislo.ToString();
    Console.WriteLine("Наименьшее число: "+ A);
}
else Console.WriteLine("Числа равны");