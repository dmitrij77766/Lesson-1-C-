//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.




/*Console.Write("Enter First Number : ");
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
} */

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Enter first number:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter third number:");
int c = int.Parse(Console.ReadLine()!);
if (a > b & a > c)
{
    Console.WriteLine($"max = {a}");
}
else if (b > c & b > a)
{
    Console.WriteLine($"max = {b}");
}
else
{
    Console.WriteLine($"max = {c}");
}