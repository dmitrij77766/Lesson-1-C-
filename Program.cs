//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



// Console.Write("Enter First Number : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Second Number : ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
// Console.WriteLine($"{a} more , {b} less");
// }
// else if (a < b)
// {
// Console.WriteLine($"{a} less, {b} more");
// }
// else
// {
// Console.WriteLine($"{a} = {b}");
// } 

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Enter first number:");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter second number:");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter third number:");
// int c = int.Parse(Console.ReadLine()!);
// if (a > b & a > c)
// {
//     Console.WriteLine($"max = {a}");
// }
// else if (b > c & b > a)
// {
//     Console.WriteLine($"max = {b}");
// }
// else
// {
//     Console.WriteLine($"max = {c}");
// }


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine("Enter number:");
// int a = int.Parse(Console.ReadLine()!);
// if (a % 2 == 0)
// {
//     Console.WriteLine($"Number {a} is even");
// }
// else
// {
//     Console.WriteLine("Number is not even");
// }


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine()!);
  
for (int i = 1; i < a; i++)
    if (i % 2 == 0)
   Console.Write($"{i},  ");
  Console.Write(a);  
   