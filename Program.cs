//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.




Console.Write("Enter First Number : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second Number : ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
Console.WriteLine($"{a} more , {b} less");
}
else if (a < b)
{
Console.WriteLine($"{a} less, {b} more");
}
else
{
Console.WriteLine($"{a} = {b}");
}
