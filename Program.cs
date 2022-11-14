// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.Write("Введите 1 число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num;
if (num > num1) max = num;
if (num1 > num2) max = num1;
if (num2 > num) max = num2;
Console.Write("Максимальное число ");
Console.Write(max);
